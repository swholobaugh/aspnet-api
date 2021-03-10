using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaAPI.Data.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
