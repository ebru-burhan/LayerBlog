using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.DataAccess.Abstracts
{
    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostById(int id);
        List<Post> GetPostsByCategoryId(int categoryId);
    }
}
