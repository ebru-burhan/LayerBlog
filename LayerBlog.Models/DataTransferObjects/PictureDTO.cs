using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Models.DataTransferObjects
{
    public class PictureDTO
    {
        public PictureDTO(Picture picture)
        {
            PictureID = picture.PictureID;
            PictureUrl = picture.PictureUrl;
            
        }
        public int PictureID { get; set; }

        // TODO:  datatype sor
        [DataType(DataType.Url)]
        [Required]
        public string PictureUrl { get; set; }
    }
}
