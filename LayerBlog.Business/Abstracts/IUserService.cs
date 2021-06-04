using LayerBlog.Entities.Concretes;
using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface IUserService : IService
    {
        List<UserDTO> GetUsers();
        UserDTO GetUserById(int id);
        void AddUser(UserDTO userDto);
        void UpdateUser(UserDTO userDto);
        void DeleteUser(int id);
    }
}
