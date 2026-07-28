using Assignment15_28july.Controllers.Models;
using Assignment15_28july.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment15_28july.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            return Ok(_courseService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            var course = _courseService.GetById(id);

            if (course == null)
            {
                return NotFound("Course not found.");
            }

            return Ok(course);
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            var newCourse = _courseService.AddCourse(course);

            return CreatedAtAction(nameof(GetCourseById),
                new { id = newCourse.Id },
                newCourse);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, Course course)
        {
            var updatedCourse = _courseService.UpdateCourse(id, course);

            if (updatedCourse == null)
            {
                return NotFound("Course not found.");
            }

            return Ok(updatedCourse);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            bool deleted = _courseService.DeleteCourse(id);

            if (!deleted)
            {
                return NotFound("Course not found.");
            }

            return Ok("Course deleted successfully.");
        }
    }

}

