using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaAPI.Data.Models;

namespace SocialMediaAPI.Data.Repositories.PostRepository
{
    public class PostRepository : DataRepository<Post>, IPostRepository
    {
        public PostRepository(DataContext dataContext) : base(dataContext)
        {

        }

    }
}
