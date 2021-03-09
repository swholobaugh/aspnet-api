using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaAPI.Data.Repositories;
using SocialMediaAPI.Data.Models;

namespace SocialMediaAPI.Data.Repository
{
    public interface IUserRepository : IDataRepository<User>
    {
        Task DeleteUser(int id);
    }
}
