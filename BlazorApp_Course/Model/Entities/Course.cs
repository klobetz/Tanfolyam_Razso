namespace BlazorApp_Course.Model.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public List<Lessen> Lessens { get; set; }
        public List<Student> Students { get; set; }
        public Instructor Instructor { get; set; }
    }
}
