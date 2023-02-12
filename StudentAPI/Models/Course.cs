using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CourseStudent> CorStd { get; set; }
    }
}
