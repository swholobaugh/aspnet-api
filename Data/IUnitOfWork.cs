using System;
using System.Collections.Generic;
using SocialMediaAPI.Data.Repositories;
using SocialMediaAPI.Data.Repository;
using SocialMediaAPI.Data.Repositories.CommentRepository;
using SocialMediaAPI.Data.Models;

namespace SocialMediaAPI.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        void Complete();
    }
}
