using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Blogs
    {
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}
