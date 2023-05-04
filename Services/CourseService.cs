using Drinks_app.Models;
using Drinks_app.Models.DTO;
using Drinks_app.Services.IServices;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Drinks_app.Exception;

namespace Drinks_app.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepo;

        public CourseService(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public async Task CreateCourse(Course course)
        {
            await _courseRepo.CreateCourse(course);
        }

        public async Task DeleteCourse(long id)
        {
            await _courseRepo.DeleteCourse(id);
        }

        public async Task<Course> GetCourseById(long id)
        {
            var result = await _courseRepo.GetCourseById(id);

            if (result == null)
            {
                throw new NotFoundException("Course not found.");
            }

            return result;
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            var result = await _courseRepo.GetCourses();

            if (result == null) 
            {
                throw new NotFoundException("Course not found.");
            }

            return result;
        }

        public async Task UpdateCourse(Course course)
        {
            await _courseRepo.UpdateCourse(course);
        }
    }
}
