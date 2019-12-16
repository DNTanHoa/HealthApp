using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class BaseModel
    {
        public Guid Oid { get; set; }

        public int OptimisticLockField { get; set; }
    }
}
