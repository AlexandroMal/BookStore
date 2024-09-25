using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Exceptions
{
    public class AuthException : Exception
    {
        public AuthException() 
            : base("Wrong login or password, authentication failed") { }
    }
}
