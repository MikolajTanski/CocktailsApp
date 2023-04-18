using System.Collections.Generic;

namespace Drinks_app.Models
{
    public class Course
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Category Category { get; set; }
        public string Content { get; set; }

    }
}
