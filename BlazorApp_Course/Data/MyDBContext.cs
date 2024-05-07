using BlazorApp_Course.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_Course.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options) { }

       DbSet<Course> Courses { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Lessen> Lessens { get; set; }
        DbSet<Student> Students { get; set; }

    }
}
