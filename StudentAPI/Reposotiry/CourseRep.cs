using StudentAPI.Models;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace StudentAPI.Reposotiry
{
    public class CourseRep : ICourseRep
    {
        private readonly Appcontext _appContext;
        public CourseRep(Appcontext appcontext) { _appContext = appcontext; }

        public void Add(Course  course)
        {
            _appContext.courses.Add(course);
            _appContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var course = _appContext.courses.Where(s => s.Id == id).FirstOrDefault();
            _appContext.courses.Remove(course);
            _appContext.SaveChangesAsync();
        }

        public IQueryable<Course> GetAll()
        {
            var Courses = _appContext.courses.AsQueryable();
            return Courses;
        }

        public Course GetById(int id)
        {
            var Courses = _appContext.courses.Where(x => x.Id == id).FirstOrDefault();
            return Courses;
        }

        public void Update(Course  course)
        {
            _appContext.courses.Update(course);
            _appContext.SaveChangesAsync();

        }
    }
}
