using Drinks_app.Models;
using Drinks_app.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Drinks_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        /*private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }*/

        [HttpGet]
        public IEnumerable<CourseHeader> GetAll()
        {
            List<CourseHeader> courses = new List<CourseHeader>();
            courses.Add(new CourseHeader
            {
                Id = 1,
                Name = "TestCourse1",
                Description = "TestCourse1 short description",
                ApplicationUser = null
            });
            courses.Add(new CourseHeader
            {
                Id = 2,
                Name = "TestCourse2",
                Description = "TestCourse2 short description"
            });
            return courses;
            //return _courseService.GetAll();
        }
    }
}
