using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Reposotiry;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRep _courseRep;
        public CourseController(ICourseRep courseRep) { _courseRep = courseRep; }

        [HttpGet]
        public IActionResult GetAll()
        {

            var Courses = _courseRep.GetAll();
            return Ok(Courses);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {

            var Course = _courseRep.GetById(id);
            return Ok(Course);
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRep.Add(course);
                return Ok(course);
            }
            return BadRequest(ModelState);
        }
        [HttpPut]
        public IActionResult UpdateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRep.Update(course);
                return Ok(course);
            }
            return BadRequest(ModelState);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _courseRep.Delete(id);
            return Ok();
        }
    }
}
