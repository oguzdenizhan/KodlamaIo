using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor = new Instructor();
            instructor.InstructorId = 1;
            instructor.CourseId = 1;
            instructor.InstructorName = "Ali Yaman";
            instructor.InstructorDescription= "Computer Engineer";
            instructor.InstructorImage = "aliyaman.png";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.CourseId = 2;
            instructor2.InstructorName = "Oktay Dere";
            instructor2.InstructorDescription = "Data Analyst ";
            instructor2.InstructorImage = "oktaydere.png";


            instructors = new List<Instructor> {instructor,instructor2 };

        }
        public void Add(Instructor intructor)
        {
            instructors.Add(intructor);
        }

        public void Delete(Instructor intructor)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor intructor)
        {
            throw new NotImplementedException();
        }

    }
}
