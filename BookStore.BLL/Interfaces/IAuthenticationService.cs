using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<Guid> AuthenticateAsync(string username, string password);
    }
}
