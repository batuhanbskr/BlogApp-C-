using Microsoft.EntityFrameworkCore;

namespace BlogApıDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OMLT132\\SQLEXPRESS01;Database=CoreBlogApiDb;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
