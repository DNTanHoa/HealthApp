using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class SystemUsers
    {
        public Guid Oid { get; set; }
        public string Username { get; set; }
        public string StoredPassword { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string password { get; set; }
    }
}
