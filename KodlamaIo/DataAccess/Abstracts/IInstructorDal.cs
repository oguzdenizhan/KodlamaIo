using KodlamaIo.Entities.Concretes;
using System.Collections.Generic;

namespace KodlamaIo.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Update(Instructor intructor);
        void Add(Instructor intructor);
        void Delete(Instructor intructor);
        List<Instructor> GetAll();
    }
}
