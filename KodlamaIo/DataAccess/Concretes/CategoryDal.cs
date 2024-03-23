using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.CategoryId = 1;
            category.CategoryName = "Programlama";

            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "Sistem";

            categories = new List<Category> { category,category2};

        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
