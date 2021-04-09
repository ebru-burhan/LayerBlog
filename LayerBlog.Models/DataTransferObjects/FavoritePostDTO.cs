using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Models.DataTransferObjects
{
    public class FavoritePostDTO
    {
        public int PostId { get; set; }
        public int UserId { get; set; }

        //--------relations
        public PostDTO Post { get; set; }
        public UserDTO User { get; set; }
    }
}
