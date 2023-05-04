using Drinks_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICourseRepository
    {
        Course GetCourseById(long id);
        Task<IEnumerable<Course>> GetCourses();
        void CreateCourse(Course courseHeader);
        void DeleteCourse(long id);
        void UpdateCourse(Course courseHeader);
    }
}
