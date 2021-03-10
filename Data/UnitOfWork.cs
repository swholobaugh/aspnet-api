using System;
using System.Collections;
using System.Collections.Generic;
using SocialMediaAPI.Data.Models;
using SocialMediaAPI.Data.Repositories;
using SocialMediaAPI.Data.Repository;
using SocialMediaAPI.Data.Repositories.CommentRepository;

using Microsoft.EntityFrameworkCore;

namespace SocialMediaAPI.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dbContext;
        public IUserRepository Users { get; }
        public IPostRepository Posts { get; }
        public ICommentRepository Comments { get; }

        public UnitOfWork(DataContext dataContext, 
            IUserRepository usersRepository, 
            IPostRepository postsRepository,
            ICommentRepository commentsRepository)
        {
            this._dbContext = dataContext;
            this.Users = usersRepository;
            this.Posts = postsRepository;
            this.Comments = commentsRepository;
        }
        

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                _dbContext.Dispose();
            }
        }

        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}
