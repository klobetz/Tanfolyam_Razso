namespace BlazorApp_Course.Model.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}
