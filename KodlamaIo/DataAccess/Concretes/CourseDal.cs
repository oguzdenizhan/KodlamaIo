using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal

    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CategoryId = 1;
            course1.CourseName = "C#";
            course1.CourseImage = "csharp.png";
            course1.CourseDescription = ".NET 8.0.....";
            course1.CoursePrice = 140;
            course1.CourseStatus=true;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CategoryId = 1;
            course2.CourseName = "Python";
            course2.CourseImage = "python.png";
            course2.CourseDescription = "python 3....";
            course2.CoursePrice = 100;
            course2.CourseStatus = false;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CategoryId = 1;
            course3.CourseName = "Java";
            course3.CourseImage = "java.png";
            course3.CourseDescription = "JDK 8....";
            course3.CoursePrice = 120;
            course3.CourseStatus = false;

            courses = new List<Course> {course1,course2,course3 };


        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return courses;

        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
