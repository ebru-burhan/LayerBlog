using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface ICategoryService : IService
    {
        void AddCategory(CategoryDTO dto);
    }
}
