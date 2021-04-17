using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Models.DataTransferObjects
{
    public class CategoryDTO
    {
        public CategoryDTO(string name)
        {
            this.Name = name;
        }

        public int CategoryID { get; set; }

        [Required]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        //---------relations
        public List<PostDTO> Posts { get; set; }
    }
}
