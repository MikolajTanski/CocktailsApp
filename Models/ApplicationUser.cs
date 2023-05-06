using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Drinks_app.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Course> Courses { get; set; }
    }
}
