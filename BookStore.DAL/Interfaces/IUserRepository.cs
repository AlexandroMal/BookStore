using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByCredentialsAsync(string username, string password);
        Task<User> GetUserByUsernameAsync(string username);
    }
}
