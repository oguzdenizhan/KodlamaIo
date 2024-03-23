using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            
        }

        public List<Category> GetAll()
        {
            //burada db işlemleri yapılır

            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

    }
}
