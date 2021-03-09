using System.Collections.Generic;

namespace SocialMediaAPI.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public IList<Post> Posts { get; } = new List<Post>();

    }
}
