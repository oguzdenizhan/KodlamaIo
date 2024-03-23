using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            //burada db işlemleri yapılır

            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

    }
}
