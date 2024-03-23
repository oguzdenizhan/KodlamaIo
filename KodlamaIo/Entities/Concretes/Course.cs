using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }

        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImage { get; set; }
        public decimal CoursePrice { get; set; }
        public bool CourseStatus {  get; set; } 
    }
}
