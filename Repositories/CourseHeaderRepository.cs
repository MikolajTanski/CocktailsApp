using Drinks_app.Data;
using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_app.Repositories
{
    public class CourseHeaderRepository : ICourseHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseHeaderRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void CreateCourseHeader(CourseHeader courseHeader)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCourseHeader(long id)
        {
            throw new System.NotImplementedException();
        }

        public CourseHeader GetCourseHeaderById(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<CourseHeader>> GetCourseHeaders()
        {
            return await _db.CourseHeaders.ToListAsync();
        }

        public void UpdateCourseHeader(CourseHeader courseHeader)
        {
            throw new System.NotImplementedException();
        }
    }
}
