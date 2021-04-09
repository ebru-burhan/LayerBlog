using LayerBlog.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class Comment : BaseEntity
    {
        public int CommentID { get; set; }
        public int PostId { get; set; }
        [Required] [MaxLength(500), MinLength(2)]
        public string Message { get; set; }

        //-------------relations
        public Post Post { get; set; }
    }
}
