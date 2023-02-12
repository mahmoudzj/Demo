using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using StudentAPI.Reposotiry;
using System.Linq;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRep _studentRep;
        public StudentController(IStudentRep studentRep) { _studentRep = studentRep;  }

        [HttpGet]
        public IActionResult GetAll()
        {

            var allStd = _studentRep.GetAll();
            return Ok(allStd);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {

            var std = _studentRep.GetById(id);
            return Ok(std);
        }

        [HttpPost]
        public IActionResult Addstudent([FromForm] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRep.Add(student);
                return Ok(student);
            }
            return BadRequest(ModelState);
        }
        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRep.Update(student);
                return Ok(student);
            }
            return BadRequest(ModelState);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _studentRep.Delete(id);
            return Ok();
        }
    }
}
