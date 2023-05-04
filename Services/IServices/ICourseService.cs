using Drinks_app.Models.DTO;
using Drinks_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drinks_app.Services.IServices
{
    public interface ICourseService
    {
        Task CreateCourse(Course course);
        Task DeleteCourse(long id);
        Task<Course> GetCourseById(long id);
        Task<IEnumerable<Course>> GetCourses();
        Task UpdateCourse(Course course);
    }
}
