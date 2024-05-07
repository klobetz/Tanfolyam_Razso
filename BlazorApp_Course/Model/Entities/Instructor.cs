namespace BlazorApp_Course.Model.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
