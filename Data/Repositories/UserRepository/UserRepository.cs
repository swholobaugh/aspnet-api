using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialMediaAPI.Data.Models;
using SocialMediaAPI.Data.Repository;

namespace SocialMediaAPI.Data.Repositories
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
        
        public virtual async Task DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.RemoveRange(user);
        }
    }
}
