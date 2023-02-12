using StudentAPI.Models;
using System.Linq;

namespace StudentAPI.Reposotiry
{
    public interface IStudentRep
    {
        IQueryable<Student> GetAll();
        Student GetById(int id);
        void Update(Student student);
        void Delete(int id);
        void Add(Student student);
         
    }
}
