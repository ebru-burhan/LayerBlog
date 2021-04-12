using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerBlog.DataAccess.Concretes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext _context) : base (_context)
        {

        }

        public List<Category> GetAllCategories()
        {
            return GetAll().ToList();
        }

        public Category GetCategoryById(int id)
        {
            return Get(x => x.CategoryID == id).FirstOrDefault();
        }
    }
}
