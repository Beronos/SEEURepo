using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEU.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public String Title { get; set; }

        public int Credits { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
