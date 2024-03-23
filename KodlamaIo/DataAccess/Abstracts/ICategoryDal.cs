using KodlamaIo.Entities.Concretes;
using System.Collections.Generic;

namespace KodlamaIo.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Update(Category category);
        void Add(Category category);
        void Delete(Category category);
        List<Category> GetAll();
    }
}
