using CodeD.Data;
using FocalLengthStatistics.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace FocalLengthStatistics
{
    public class HeatMap
    {
        public string OutputFileName { get; set; }
        public bool EnableLogScale { get; set; } //撮影枚数を対数表示にする

        /// <summary>
        /// /// heat map表示用CSVファイルを作成する
        /// </summary>
        /// <param name="outputFileName"></param>
        /// <param name="cameras"></param>
        /// <param name="fRangeBegin">検索範囲始点 焦点距離 [mm]</param>
        /// <param name="fRangeEnd">検索範囲終点 焦点距離 [mm]</param>
        public void CreateCSVByModels(string outputFileName, List<string> cameras,DateTime dtBegin, DateTime dtEnd, int fRangeBegin = 1, int fRangeEnd = 150)
        {
            OutputFileName = outputFileName;
            var outputStatistics = new StringBuilder();
            var sqlite = new SQLiteManager();

            for (var dt = dtBegin; dt <= dtEnd; dt = dt.AddMonths(1))
            {
                var begin = dt.ToString("yyyy-MM-dd 00:00:00");
                var end = dt.AddMonths(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss");
                var data = sqlite.Query($"select * from Statistics where timestamp between '{begin}' and '{end}'");
                var data1Month = data.Where(exif => cameras.Contains(exif.Model))
                                     .ToArray(); // 一度確定させる（↓内部で複数回参照するため。）

                outputStatistics.AppendLine(Create1MonthData(fRangeBegin, fRangeEnd, data1Month));
            }
            File.WriteAllText(OutputFileName, outputStatistics.ToString());
        }

        /// <summary>
        /// heatmap表示用CSVファイルの作成 LensTypeで限定する
        /// </summary>
        /// <param name="v"></param>
        /// <param name="lenstype"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        internal void CreateCSVByLensType(string outputFileName, string lenstype, DateTime dtBegin, DateTime dtEnd, int fRangeBegin, int fRangeEnd)
        {
            OutputFileName = outputFileName;
            var outputStatistics = new StringBuilder();
            var sqlite = new SQLiteManager();

            for (var dt = dtBegin; dt <= dtEnd; dt = dt.AddMonths(1))
            {
                var begin = dt.ToString("yyyy-MM-dd 00:00:00");
                var end = dt.AddMonths(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss");
                var data = sqlite.Query($"select * from Statistics where lenstype = '{lenstype}' and timestamp between '{begin}' and '{end}'");
                var data1Month = data.ToArray(); // 一度確定させる（↓内部で複数回参照するため。）

                outputStatistics.AppendLine(Create1MonthData(fRangeBegin, fRangeEnd, data1Month));
            }
            File.WriteAllText(OutputFileName, outputStatistics.ToString());
        }

        /// <summary>
        /// ある月のデータにおける、各焦点距離での撮影枚数をカウントして
        /// , で繋げて返す
        /// </summary>
        /// <param name="fRangeBegin"></param>
        /// <param name="fRangeEnd"></param>
        /// <param name="data1Month"></param>
        private string Create1MonthData(int fRangeBegin, int fRangeEnd, Exif[] data1Month)
        {
            var countList = new List<double>(); //対数表示の際、値が小数になるため
            for (int f = fRangeBegin; f < fRangeEnd; f++)
            {
                var count = data1Month.Where(exif => exif.FocalLength35mmEq >= f 
                                                && exif.FocalLength35mmEq < f + 1)
                                      .Count();
                if (EnableLogScale)
                {
                    countList.Add( Math.Log(count + 1));
                }
                else
                {
                    countList.Add(count);
                }
            }
            return string.Join(",", countList);
        }

        /// <summary>
        /// Heat map （Bitmap）を作成する
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateImage()
        {
            var zmap = new ZMappingData(OutputFileName);

            return zmap.ToBitmap();
        }
    }
}