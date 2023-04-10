using Drinks_app.Models;
using Drinks_app.Models.DTO;
using Drinks_app.Services.IServices;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;

namespace Drinks_app.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseHeaderRepository _courseHeadRepo;
        private readonly ICourseContentRepository _courseContentRepo;

        public CourseService(
            ICourseHeaderRepository courseHeadRepo,
            ICourseContentRepository courseContentRepo)
        {
            _courseHeadRepo = courseHeadRepo;
            _courseContentRepo = courseContentRepo;
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
