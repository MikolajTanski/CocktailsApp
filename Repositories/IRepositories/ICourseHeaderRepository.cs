using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICourseHeaderRepository
    {
        CourseHeader GetCourseHeaderById(long id);
        IEnumerable<CourseHeader> GetCourseHeaders();
        void CreateCourseHeader(CourseHeader courseHeader);
        void DeleteCourseHeader(long id);
        void UpdateCourseHeader(CourseHeader courseHeader);
    }
}
