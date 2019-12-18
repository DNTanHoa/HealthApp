using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class SystemRoles
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
