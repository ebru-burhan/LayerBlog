using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Models.DataTransferObjects
{
    public class CommentDTO
    {
        public int CommentID { get; set; }
        public int PostId { get; set; }
        [Required]
        [MaxLength(500), MinLength(2)]
        public string Message { get; set; }

        //-------------relations
        public PostDTO Post { get; set; }
    }
}
