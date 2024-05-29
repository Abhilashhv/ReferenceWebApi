using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReferenceWebApi.Models;
using ReferenceWebApi.Services;

namespace ReferenceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepo courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var course = await courseRepo.GetCourseByIdAsync(id);
            if (course == null) { return NotFound(); }
            return Ok(course);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await courseRepo.GetCoursesAsync();
            return Ok(courses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] Course course)
        {
            var result = await courseRepo.CreateCourseAsync(course);
            return Ok(result);
        }

        
    }
}
