using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.DataAccess.Abstracts
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
    }
}
