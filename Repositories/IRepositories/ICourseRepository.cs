using Drinks_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseById(long id);
        Task<IEnumerable<Course>> GetCourses();
        Task CreateCourse(Course courseHeader);
        Task DeleteCourse(long id);
        Task UpdateCourse(Course courseHeader);
        Task<IEnumerable<Course>> GetCoursesWithSubEntities();
        Task<IEnumerable<Course>> GetCoursesForSpecyficUser(string userName);

    }
}
