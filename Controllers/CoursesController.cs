using Drinks_app.Models;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Drinks_app.Controllers
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(long id)
        { //user//category
            var course = await _courseService.GetCourseById(id);

            return Ok(course);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            var courses = await _courseService.GetCourses();
            return Ok(courses);
        }
        [HttpGet]
        [Route("WithSubEntities")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCoursesWithSubEntieties()
        {
            var courses = await _courseService.GetCoursesWithSubEntieties();
            return Ok(courses);
        }
        
        [HttpGet]
        [Authorize]
        [Route("GetCoursesForSpecyficUser")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCoursesForSpecyficUser()
        {
            string userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);

            var courses = await _courseService.GetCoursesForSpecyficUser(userName);
            return Ok(courses);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCourse([FromBody] Course course)
        {
            await _courseService.CreateCourse(course);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCourse(long id, [FromBody] Course course)
        {
            await _courseService.UpdateCourse(course);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCourse(long id)
        {
            await _courseService.DeleteCourse(id);
            return Ok();
        }
    }
}
