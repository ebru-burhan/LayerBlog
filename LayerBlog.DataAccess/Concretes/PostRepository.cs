using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
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
            return Get(x => x.PostID == id).FirstOrDefault();
        }
    }
}
