using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerBlog.DataAccess.Concretes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext _context) : base(_context)
        {

        }
        public List<User> GetAllUsers()
        {
            return GetAll().ToList();
        }

        public User GetUserById(int id)
        {
            return Get(x => x.UserID == id).FirstOrDefault();
        }
    }
}
