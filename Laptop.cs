using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Laptop
    {
        bool applicable;
        public string OS { get; set; }
        public int Battery { get; set; }
        public Сore CPU { get; set; }
        public DiskValue Disk { get; set; }

        public Laptop(string windows, int hour, DiskValue mydisk)
        {
            OS = windows;
            Battery = hour;
            Disk = mydisk;

        }
        public Laptop(DiskValue mydisk)
        {
            mydisk.Value = 16;
        }
        public bool Fit
        {
            get
            {
                return applicable;
            }
            set
            {
                if (Disk.Value < 16)
                    applicable = false;
                else
                    applicable = true;
            }
        }
        public Laptop(int coreNum)
        {
            CPU.CoreQuantity = coreNum;
        }

    }
}
