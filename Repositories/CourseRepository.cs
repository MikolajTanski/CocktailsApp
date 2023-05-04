using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_app.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void CreateCourse(Course courseHeader)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCourse(long id)
        {
            throw new System.NotImplementedException();
        }

        public Course GetCourseById(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await _db.Courses.ToListAsync();
        }

        public void UpdateCourse(Course courseHeader)
        {
            throw new System.NotImplementedException();
        }
    }
}
