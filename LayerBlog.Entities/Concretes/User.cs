using LayerBlog.Entities.Abstracts;
using LayerBlog.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public int? PictureId { get; set; }

        [Required][MaxLength(50), MinLength(2)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required] [MaxLength(50), MinLength(2)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required] [MaxLength(50), MinLength(2)]
        public string Password { get; set; }

        [Required] [MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [Required] [MaxLength(50), MinLength(2)]
        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        //-----relations
        public Picture Picture { get; set; }
        public ICollection<FavoritePost> FavoritePosts { get; set; }
    }
}
