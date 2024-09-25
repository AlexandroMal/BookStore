using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDatabaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> GetUserByCredentialsAsync(string username, string password)
        {
            var result = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.UserName == username && x.Password == password);
            return result;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            var result = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.UserName == username);
            return result;
        }
    }
}
