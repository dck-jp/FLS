using Dapper;
using FocalLengthStatistics.Model;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace FocalLengthStatistics
{
    public class SQLiteManager
    {
        private static readonly string DBFileName = "Statistics.db";
        private static readonly string TableName = "Statistics";

        public SQLiteManager()
        {
        }

        public void CreateEmptyDB()
        {
            if (File.Exists(DBFileName)) { File.Delete(DBFileName); }

            using (var conn = new SQLiteConnection("Data Source=" + DBFileName))
            {
                conn.Open();
                var cmd = $"create table {TableName}("
                            + "filename TEXT PRIMARY KEY,"
                            + "model TEXT," //ボディ
                            + "timestamp TEXT," //撮影日時
                            + "exposuretime REAL,"
                            + "fnumber REAL,"
                            + "isospeed INTEGER,"
                            + "focallength REAL,"
                            + "focallength35mmeq REAL,"
                            + "lenstype TEXT" //レンズ名
                            + ")";
                conn.Execute(cmd);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public IEnumerable<Exif> Query(string sql)
        {
            using (var conn = new SQLiteConnection("Data Source=" + DBFileName))
            {
                conn.Open();
                var x = conn.Query<Exif>(sql);
                return x;
            }
        }

        public void Write(IEnumerable<Exif> data)
        {
            using (var conn = new SQLiteConnection("Data Source=" + DBFileName))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        //要実装
                        conn.Execute($"INSERT INTO {TableName}(filename, model, timestamp, exposuretime, fnumber, isospeed, focallength, focallength35mmeq, lenstype) VALUES (@FileName, @Model, @TimeStamp, @ExposureTime, @FNumber, @ISOSpeed, @FocalLength, @FocalLength35mmEq, @LensType)", data.AsList().ToArray(), tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                    }
                }
            }
        }
    }
}