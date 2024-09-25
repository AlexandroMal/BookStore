using AutoMapper;
using BookStore.BLL.Exceptions;
using BookStore.BLL.Interfaces;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AuthenticationService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<Guid> AuthenticateAsync(string username, string passwrod)
        {
            try
            {
                var user = await _userRepository.GetUserByCredentialsAsync(username, passwrod);

                if (user != null)
                {
                    return user.Id;
                }
                else
                {
                    throw new AuthException();
                }
            }
            catch (AuthException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }
    }
}
