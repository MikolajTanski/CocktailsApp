
using System.ComponentModel.DataAnnotations;

namespace Drinks_app.Models
{
    public class Category
    {
        public long Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
    }
}
