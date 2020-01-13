using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class PostContent
    {
        public int Oid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? Post { get; set; }

        public Post PostNavigation { get; set; }
    }
}
