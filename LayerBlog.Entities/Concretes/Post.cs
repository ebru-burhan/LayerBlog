using LayerBlog.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class Post : BaseEntity
    {
        public int PostID { get; set; }
        public int CategoryId { get; set; }
        public int? PictureId { get; set; }

        [Required] [MaxLength(500), MinLength(2)]
        public string Title { get; set; }

        [Required] [MinLength(2)]
        public string Description { get; set; }



        //----relations
        public Category Category { get; set; }
        public ICollection<FavoritePost> FavoritePosts { get; set; }
        public Picture Picture { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
