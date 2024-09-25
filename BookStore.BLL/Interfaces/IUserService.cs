using BookStore.BLL.Models;
using BookStore.BLL.Models.AddModels;
using BookStore.BLL.Models.UpdateModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    public interface IUserService
    {
        public Task AddUserAsync(AddUserModel userModel);
        public Task UpdateUserAsync(UpdateUserModel userModel);
        public Task DeleteUserAsync(Guid id);
        public Task<UserModel> GetUserAsync(Guid id);

    }
}
