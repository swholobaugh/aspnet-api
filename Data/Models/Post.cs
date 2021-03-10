using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaAPI.Data.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public DateTime PublishedOn { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IList<Comment> Comments { get; } = new List<Comment>();
    }
}
