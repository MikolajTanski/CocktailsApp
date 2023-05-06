using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Drinks_app.Models
{
    public class Course
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Category Category { get; set; }
        public string Content { get; set; }

    }
}
