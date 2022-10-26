using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Offer1.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Mode { get; set; }
        public string MovementType { get; set; }
        public string Incoterm { get; set; }
        public string Countries { get; set; }
        public string Cities { get; set; }
        public string PackageType { get; set; }
        public string Unit1 { get; set; }
        public int Size { get; set; }

        public string Unit2 { get; set; }
        public int Kilo { get; set; }

        public string Currency { get; set; }
        public int Teklif { get; set; }
    }
}