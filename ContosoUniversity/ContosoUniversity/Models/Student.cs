using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Nav Property below is a 1-to-Many relationship, hence LIST
        //EF creates HashSet by default for ICollection<T>
        public ICollection<Enrollment> Enrollments { get; set; } //Navigation Property
    }
}
