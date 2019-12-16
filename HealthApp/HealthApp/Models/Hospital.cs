using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class Hospital : BaseModel
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Address { get; set; }

        public decimal rate { get; set; }
    }
}
