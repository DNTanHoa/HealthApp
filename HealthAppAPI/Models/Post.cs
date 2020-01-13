using System;
using System.Collections.Generic;

namespace HealthAppAPI.Models
{
    public partial class Post
    {
        public Post()
        {
            PostContent = new HashSet<PostContent>();
        }

        public string Title { get; set; }
        public int Oid { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }

        public PostCategory CategoryNavigation { get; set; }
        public ICollection<PostContent> PostContent { get; set; }
    }
}
