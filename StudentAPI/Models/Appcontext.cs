using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class Appcontext : DbContext
    {
        public Appcontext(DbContextOptions<Appcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudent>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }

        public DbSet<Student>  students { get; set; }
        public DbSet<Course>  courses { get; set; }
        public DbSet<CourseStudent>  courseStudents { get; set; }
    }
}
