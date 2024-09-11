using Microsoft.EntityFrameworkCore;
namespace ITILAB.Models
{
    public class ITIContext : DbContext
    {
        public ITIContext(DbContextOptions<ITIContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
