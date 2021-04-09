using LayerBlog.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }

        [Required] [MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        //---------relations
        public  ICollection<Post> Posts { get; set; }
    }
}
