using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Models
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
