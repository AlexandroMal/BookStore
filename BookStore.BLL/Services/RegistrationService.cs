using AutoMapper;
using BookStore.BLL.Exceptions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models.AddModels;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services
{
    public class RegistrationService : IRegistrationService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public RegistrationService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }

        public async Task RegisterAsync(AddUserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                throw new ModelIsEmptyException();
            }

            var existingUser = await _userRepository.GetUserByUsernameAsync(userModel.UserName);
            if (existingUser != null) 
            {
                throw new UserAlreadyExistsException();
            }

            var user = _mapper.Map<User>(userModel);
            await _userRepository.AddAsync(user);
        }
    }
}
