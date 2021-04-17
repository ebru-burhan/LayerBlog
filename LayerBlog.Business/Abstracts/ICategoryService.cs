using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface ICategoryService : IService
    {
        List<CategoryDTO> GetCategories();
        CategoryDTO GetCategoryById(int id);
        void AddCategory(CategoryDTO dto);
        void UpdateCategory(CategoryDTO dto);
        void DeleteCategory(int id);
    }
}
