using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerBlog.DataAccess.Concretes
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(DataContext _context) : base(_context)
        {
        }

        public Post GetPostById(int id)
        {
            //salak ebru yapma bi daha böyle bişi
            //return context.Set<Post>().Find(id);

            //TODO: NOT!!! include ederken string yerine nameof içine hangi classı yazacaksan onun adı

            return Get(x => x.PostID == id).Include(nameof(Category)).FirstOrDefault();
        }

        public List<Post> GetPostsByCategoryId(int categoryId)
        {
            return Get(x => x.CategoryId == categoryId).Include(nameof(Category)).ToList();
        }
    }
}
