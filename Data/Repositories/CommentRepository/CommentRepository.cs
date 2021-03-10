using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaAPI.Data.Models;

namespace SocialMediaAPI.Data.Repositories.CommentRepository
{
    public class CommentRepository : DataRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
