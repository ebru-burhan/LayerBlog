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

        public CategoryDTO GetCategoryById(int id)
        {
            return _mapper.Map<CategoryDTO>(_categoryRepository.GetCategoryById(id));
        }

        public void AddCategory(CategoryDTO dto)
        {
            _categoryRepository.Add(_mapper.Map<Category>(dto));
        }

        public void UpdateCategory(CategoryDTO dto)
        {
            //tracking sorunu çözüldü burda yeni oluşturma dto geleni eşitle denildi generic repo da asnotracking yerine bu daha sağlıklı gbi hocamızın yaptığı yolda state değiştirmekti o da kullanılabilir 3 seçenek bu sefer maplerken yeni bişi oluşturmasına fırsat vermeden verileri atattırdık
            var category = _categoryRepository.GetCategoryById(dto.CategoryID);
            //aldık category i update yaprken dtodaki verileri category e eşitle dedk
            _categoryRepository.Update(_mapper.Map(dto, category));
        }

        public void DeleteCategory(int id)
        {
            //get yapıp siliyoz hmm ne yapsak acabaa hmmmmm
            _categoryRepository.Delete(_categoryRepository.GetCategoryById(id));
        }
    }
}
