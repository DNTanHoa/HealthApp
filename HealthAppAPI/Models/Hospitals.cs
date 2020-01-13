using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class Hospitals
    {
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? Region { get; set; }

        public Regions RegionNavigation { get; set; }
    }
}
