using Drinks_app.Models;
using System.Collections.Generic;

namespace Drinks_app.Repositories.IRepositories
{
    public interface ICourseContentRepository
    {
        IEnumerable<CourseContent> GetCourseContentsById(long CourseHeaderId);
        void CreateCourseContent(IEnumerable<CourseContent> courseContents);
        void UpdateCourseContent(IEnumerable<CourseContent> courseContents);
    }
}
