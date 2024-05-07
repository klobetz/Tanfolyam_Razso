namespace BlazorApp_Course.Model.Entities
{
    public class Lessen
    {
        public int LessenId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
