using System.Collections.Generic;

namespace FocalLengthStatistics
{
    public class Config
    {
        public string SearchDirectoryPath { get; set; }
        public List<string> SearchExtensions { get; set; }
        public List<string> ExclusionFiles { get; set; }

        public string SQLiteOutputPath { get; set; }
    }
}