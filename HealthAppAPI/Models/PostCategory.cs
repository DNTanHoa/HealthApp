using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class PostCategory
    {
        public PostCategory()
        {
            Post = new HashSet<Post>();
        }

        public string Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
