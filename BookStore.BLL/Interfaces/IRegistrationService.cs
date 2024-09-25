using BookStore.BLL.Models.AddModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    public interface IRegistrationService
    {
        public Task RegisterAsync(AddUserModel addUser);
    }
}
