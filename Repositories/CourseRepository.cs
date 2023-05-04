using Drinks_app.Data;
using Drinks_app.Exception;
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

        public async Task CreateCourse(Course courseHeader)
        {
            await _db.Courses.AddAsync(courseHeader);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteCourse(long id)
        {
            var courseToDelete = await _db.Courses.FindAsync(id);

            if (courseToDelete is null)
            {
                throw new NotFoundException("Course not found.");
            }

            _db.Courses.Remove(courseToDelete);
            await _db.SaveChangesAsync();
        }

        public async Task<Course> GetCourseById(long id)
        {
            var result = await _db.Courses.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            var result = await _db.Courses.ToListAsync();
            return result;
        }

        public async Task UpdateCourse(Course courseHeader)
        {
            _db.Courses.Update(courseHeader);
            await _db.SaveChangesAsync();
        }
    }

}
