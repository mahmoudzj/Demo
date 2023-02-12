namespace StudentAPI.Models
{
    public class CourseStudent
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
        public Student student { get; set;}
    }
}
