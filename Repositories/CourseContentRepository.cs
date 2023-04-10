using Drinks_app.Models;
using Drinks_app.Repositories.IRepositories;
using System.Collections.Generic;

namespace Drinks_app.Repositories
{
    public class CourseContentRepository : ICourseContentRepository
    {
        public void CreateCourseContent(IEnumerable<CourseContent> courseContents)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CourseContent> GetCourseContentsById(long CourseHeaderId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCourseContent(IEnumerable<CourseContent> courseContents)
        {
            throw new System.NotImplementedException();
        }
    }
}
