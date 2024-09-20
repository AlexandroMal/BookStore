using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
        {
        }

        public Task<User> GetUserByCredentialsAsync(string name, string password)
        {
            throw new NotImplementedException();
        }
    }
}
