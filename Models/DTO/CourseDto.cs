using System.Collections.Generic;

namespace Drinks_app.Models.DTO
{
    public class CourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public ApplicationUser Author { get; set; }

        public string Content { get; set; }
    }
}
