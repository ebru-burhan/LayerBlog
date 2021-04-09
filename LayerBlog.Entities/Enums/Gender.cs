using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Entities.Enums
{
    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male,
        [Display(Name = "Kadın")]
        Female
    }
}
