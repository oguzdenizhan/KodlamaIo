using KodlamaIo.Business.Concretes;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses= courseManager.GetAll();

            Course course = new Course();
            course.CourseId = 4;
            course.CategoryId = 1;
            course.CourseName = "React";
            course.CourseImage = "react.png";
            course.CourseDescription = "web design....";
            course.CoursePrice = 110;
            course.CourseStatus = true;
            
            courses.Add(course);

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i].CourseName + " / " + courses[i].CoursePrice);

                
            }

            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            List<Instructor> instructors= instructorManager.GetAll();

            Instructor instructor = new Instructor();
            instructor.InstructorId = 3;
            instructor.CourseId = 3;
            instructor.InstructorName = "Oğuzhan Denizhan";
            instructor.InstructorDescription = "Computer Engineer";
            instructor.InstructorImage = "oguzhandenizhan.png";

            instructorManager.Add(instructor);

            for (int i = 0;i < instructors.Count; i++)
            {
                Console.WriteLine(instructors[i].InstructorName + " " + instructors[i].InstructorDescription);
            }

            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories= categoryManager.GetAll();
            Category category = new Category();
            category.CategoryId = 3;
            category.CategoryName = "Kişisel Gelişim";
            categories.Add(category);

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(categories[i].CategoryName);
            }


            Console.ReadLine();
        }
    }
}
