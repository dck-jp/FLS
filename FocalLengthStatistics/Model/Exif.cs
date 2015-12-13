using System;

namespace FocalLengthStatistics.Model
{
    public class Exif
    {
        public string FileName { get; set; }
        public string Model { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ExposureTime { get; set; }
        public double FNumber { get; set; }
        public int ISOSpeed { get; set; }
        public double FocalLength { get; set; }
        public double FocalLength35mmEq { get; set; }
        public string LensType { get; set; }
    }
}