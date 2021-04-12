using AutoMapper;
using LayerBlog.Business.Abstracts;
using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public List<CategoryDTO> GetCategories()
        {
           var categories= _categoryRepository.GetAllCategories();
            return _mapper.Map<List<CategoryDTO>>(categories); 

        }

        public CategoryDTO GetCategoryDtoById(int id)
        {
            return _mapper.Map<CategoryDTO>(_categoryRepository.GetCategoryById(id));
        }

        public void AddCategory(CategoryDTO dto)
        {
            _categoryRepository.Add(_mapper.Map<Category>(dto));
        }
    }
}
