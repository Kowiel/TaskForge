using Microsoft.EntityFrameworkCore;
using TaskForge.Shered;

namespace TaskForge.DB_Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public virtual DbSet<TestClass> TestClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestClass>().HasData(
                new TestClass { Id = 1, Email = "alice@example.com", Name = "Alice", Description = "Seed user Alice" },
                new TestClass { Id = 2, Email = "bob@example.com", Name = "Bob", Description = "Seed user Bob" },
                new TestClass { Id = 3, Email = "charlie@example.com", Name = "Charlie", Description = "Seed user Charlie" }
            );
        }
    }

}
