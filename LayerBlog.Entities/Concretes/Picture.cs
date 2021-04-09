using LayerBlog.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Concretes
{
    public class Picture : BaseEntity
    {
        public int PictureID { get; set; }

        // TODO:  datatype sor
        [DataType(DataType.Url)] [Required]
        public string PictureUrl { get; set; }
    }
}
