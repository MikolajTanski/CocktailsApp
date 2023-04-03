using System.Collections.Generic;

namespace Drinks_app.Models
{
    public class CourseHeader
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
