using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class SystemUsers
    {
        public Guid Oid { get; set; }
        public string Username { get; set; }
        public string StoredPassword { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
