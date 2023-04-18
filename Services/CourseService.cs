using Drinks_app.Models;
using Drinks_app.Models.DTO;
using Drinks_app.Services.IServices;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;

namespace Drinks_app.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepo;

        public CourseService(
            ICourseRepository courseRepo
            )
        {
            _courseRepo = courseRepo;
        }

        public void CreateCourse(CourseDto courseDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCourse(long id)
        {
            throw new System.NotImplementedException();
        }

        public CourseDto GetCourseById(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CourseDto> GetCourses()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCourse(CourseDto courseDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
