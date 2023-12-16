using System;
using System.Net.NetworkInformation;

namespace DVDAPI.model
{
    public class DVD
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
        public string? OutputMode { get; set; }
        public string? DiskType { get; set; }
        public int Volume { get; set; }
        public bool Pause { get; set; }
        public bool Stop { get; set; }
        public bool Play { get; set; }
        public bool Eject { get; set; }
        public bool Close { get; set; }

    }
}

