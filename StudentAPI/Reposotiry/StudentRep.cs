using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace StudentAPI.Reposotiry
{
    public class StudentRep : IStudentRep
    {
        private readonly Appcontext _appContext;
        public StudentRep(Appcontext appcontext) { _appContext = appcontext; }

        public void Add(Student student)
        {
            _appContext.students.Add(student);
            _appContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var std = _appContext.students.Where(s => s.Id == id).FirstOrDefault();
            _appContext.students.Remove(std);
            _appContext.SaveChangesAsync();
        }

        public IQueryable<Student> GetAll()
        {
            var allStd = _appContext.students.AsQueryable().Include(a=>a.CorStd).ThenInclude(a=>a.course);
            return allStd;
        }

        public Student GetById(int id)
        {
            var Std = _appContext.students.Where(x => x.Id == id).FirstOrDefault();
            return Std;
        }

        public void Update(Student student)
        {
            _appContext.students.Update(student);
            _appContext.SaveChangesAsync();

        }
    }
}
