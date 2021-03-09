using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using SocialMediaAPI.Data.Models;
using SocialMediaAPI.Data;
using SocialMediaAPI.Data.Repository;
using SocialMediaAPI.Data.Repositories;
using SocialMediaAPI.Data.Repositories.PostRepository;

namespace SocialMediaAPI.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<DataContext>(opt => opt
                .UseSqlServer("Server=DESKTOP-RDB8UF6\\SQLEXPRESS; Database=SocialAPI; Trusted_Connection=True;"));
            return services;
        }
    }
}
