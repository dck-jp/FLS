using FocalLengthStatics.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FocalLengthStatics
{
    public class StaticsSQLite
    {
        /// <summary>
        /// Exiv2.exeのパス
        /// </summary>
        public string Exiv2Path { get; set; }

        /// <summary>
        /// Exiv2の出力をまとめたCSVファイルを作成
        /// </summary>
        /// <param name="outputFileName">出力ファイルのパス</param>
        public void Create()
        {
            var OutputFileName = Core.Config.SQLiteOutputPath;
            var CheckPath = Core.Config.SearchDirectoryPath;
            Exiv2Path = Environment.CurrentDirectory + @"\Exiv2\exiv2.exe";

            //1.指定したディレクトリ下の写真を拾う
            var files = new List<string>();
            Core.Config.SearchExtensions.ForEach(ext =>
            {
                files.AddRange(Directory.EnumerateFiles(CheckPath, ext, SearchOption.AllDirectories));
            });
            //例外ファイルを除去
            files = files.Where(file => !Core.Config.ExclusionFiles.Exists(x => file.Contains(x))).ToList();

            var totalCount = files.Count();
            var count = 0;
            var exifs = new List<Exif>();
            var obj = new object();

            var sqlite = new SQLiteManager();
            sqlite.CreateEmptyDB();

            files.AsParallel().WithDegreeOfParallelism(30).ForAll(file =>
            {
                //2-1.exifデータを取得   exiv2の標準出力を横取り
                string exiv2Output = RunExiv2(Exiv2Path, file);
                //exiv2の出力をぱーすして SQLiteに放り込むデータ作成
                var exif = ParseExif(exiv2Output);
                exif.FileName = file;
                lock (obj)
                {
                    exifs.Add(exif);
                    count++;
                    ReportProgress(totalCount, count);

                    if (exifs.Count > 1000)
                    {
                        sqlite.Write(exifs);
                        exifs.Clear();
                    }
                }
            });
        }

        private Exif ParseExif(string exiv2Output)
        {
            var exif = new Exif();

            var parameters = new StringReader(exiv2Output);
            while (parameters.Peek() > -1)
            {
                var parameter = parameters.ReadLine();
                var p = parameter.Split(new[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
                AddParameter(p, ref exif); //pの内容を見て、適宜Exifに値を代入
            }

            return exif;
        }

        private void AddParameter(string[] p, ref Exif exif)
        {
            if (p.Length < 4) return;

            var itemTitle = p[0].Trim();
            var value = p[3].Trim();

            switch (itemTitle)
            {
                case "Exif.Image.Model":
                    exif.Model = value;
                    break;

                case "Exif.Photo.DateTimeOriginal":
                    exif.TimeStamp = ParseDateTime(value);
                    break;

                case "Exif.Photo.ExposureTime":
                    exif.ExposureTime = value.Replace(" s", "");
                    break;

                case "Exif.Photo.FNumber":
                    exif.FNumber = double.Parse(value.Replace("F", ""));
                    break;

                case "Exif.Photo.ISOSpeedRatings":
                    exif.ISOSpeed = int.Parse(value);
                    break;

                case "Exif.Photo.FocalLength":
                    exif.FocalLength = double.Parse(value.Replace(" mm", ""));
                    break;

                case "Exif.PentaxDng.LensType":
                    exif.LensType = value;
                    break;

                case "Exif.Pentax.LensType":
                    exif.LensType = value;
                    break;

                case "Exif.Photo.FocalLengthIn35mmFilm":
                    if (value == "Unknown") break;
                    exif.FocalLength35mmEq = double.Parse(value.Replace(" mm", ""));
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Exiv2の出力形式のDateTimeをパースする
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private DateTime ParseDateTime(string value)
        {
            var result = new DateTime();
            return DateTime.TryParseExact(value, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result) ? result : result;    
        }

        /// <summary>
        /// 進捗状況をFormMainに反映
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="count"></param>
        private static void ReportProgress(int totalCount, int count)
        {
            var percentage = 100 * count / totalCount;
            Core.FormMain.ProgressPercentage = percentage;
        }

        /// <summary>
        /// Exiv2を実行して、出力を受け取る
        /// </summary>
        /// <param name="exiv2ExePath">Exiv2.exeのpath</param>
        /// <param name="targetFilePath">Exiv2.exeに渡すファイルのpath</param>
        /// <returns></returns>
        private string RunExiv2(string exiv2ExePath, string targetFilePath)
        {
            targetFilePath = "\"" + targetFilePath + "\"";

            try
            {
                var process = new Process();
                process.StartInfo.FileName = exiv2ExePath;
                process.StartInfo.Arguments = $"-PEkyct {targetFilePath}";

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                var temp = process.StandardOutput.ReadToEnd();
                process.WaitForExit(1 * 60 * 1000); //wait 1 minites
                temp += process.StandardOutput.ReadToEnd();

                process.Close();
                return temp;
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.ToString());
            }
        }
    }
}