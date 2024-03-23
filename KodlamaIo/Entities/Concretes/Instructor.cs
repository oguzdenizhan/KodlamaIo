using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes
{

    public class Instructor
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorDescription { get; set; }
        public string InstructorImage { get; set; }
    }
}
