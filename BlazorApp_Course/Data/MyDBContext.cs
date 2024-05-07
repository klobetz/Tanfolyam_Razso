using Microsoft.EntityFrameworkCore;

namespace BlazorApp_Course.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options) { }

       

    }
}
