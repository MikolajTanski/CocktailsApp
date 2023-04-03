namespace Drinks_app.Models
{
    public class CourseContent
    {
        public long Id {get; set;}
        public virtual CourseHeader CourseHeader { get; set;}
        public long ContentNumber { get; set;}
        public string Content { get; set;}
    }
}
