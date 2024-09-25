using AutoMapper;
using BookStore.BLL.Exceptions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.AddModels;
using BookStore.BLL.Models.UpdateModels;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task AddUserAsync(AddUserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                throw new ModelIsEmptyException();
            }
            
            var mapper = _mapper.Map<User>(userModel);

            await _userRepository.AddAsync(mapper);
        }

        public async Task UpdateUserAsync(UpdateUserModel userModel)
        {
            if (!string.IsNullOrEmpty(userModel.UserName) && string.IsNullOrEmpty(userModel.Password))
            {
                throw new ModelIsEmptyException();
            }

            var user = await _userRepository.GetByIdAsync(Guid.Parse(userModel.Id));
            var mapper = _mapper.Map<User>(user);

            await _userRepository.UpdateAsync(mapper);
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserModel> GetUserAsync(Guid id)
        {
            var user = _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserModel>(user);
        }
    }
}
