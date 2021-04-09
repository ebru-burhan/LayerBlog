using LayerBlog.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class FavoritePost : BaseEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }

        //--------relations
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
