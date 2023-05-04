using Drinks_app.Models.DTO;
using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Services.IServices
{
    public interface ICourseService
    {
        CourseDto GetCourseById(long id);
        IEnumerable<CourseDto> GetCourses();
        void CreateCourse(CourseDto courseDto);
        void DeleteCourse(long id);
        void UpdateCourse(CourseDto courseDto);
    }
}
