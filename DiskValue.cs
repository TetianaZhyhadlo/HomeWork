using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class DiskValue
    {
        public int Value { get; set; }
        public string DiskType { get; set; }
        public DiskValue(int lapDisk, string lapDiskType)
        {
            Value = lapDisk;
            DiskType = lapDiskType;
        }
    }
}
