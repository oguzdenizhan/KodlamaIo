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
    public class InstructorManager 
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetAll()
        {
            //burada db işlemleri yapılır

            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

    }
}
