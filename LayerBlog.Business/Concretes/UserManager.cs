using AutoMapper;
using LayerBlog.Business.Abstracts;
using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserDTO> GetUsers()
        {
            return _mapper.Map<List<UserDTO>>(_userRepository.GetAllUsers());
        }


        public void AddUser(UserDTO userDto)
        {
            _userRepository.Add(_mapper.Map<User>(userDto));
        }

        public void UpdateUser(UserDTO userDto)
        {
            var user = _userRepository.GetUserById(userDto.UserID);
            _userRepository.Update(_mapper.Map(userDto, user));
        }

        public void DeleteUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            _userRepository.Delete(user);
        }
    }
}
