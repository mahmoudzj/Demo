using StudentAPI.Models;
using System.Linq;

namespace StudentAPI.Reposotiry
{
    public interface ICourseRep
    {
        IQueryable<Course> GetAll();
        Course GetById(int id);
        void Update(Course student);
        void Delete(int id);
        void Add(Course student);
         
    }
}
