using System.Collections;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public ICollection<CourseStudent> CorStd { get; set; }
    }
}
