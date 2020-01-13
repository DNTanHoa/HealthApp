using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class Regions
    {
        public Regions()
        {
            Hospitals = new HashSet<Hospitals>();
        }

        public int Oid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public ICollection<Hospitals> Hospitals { get; set; }
    }
}
