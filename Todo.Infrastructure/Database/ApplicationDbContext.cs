using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoApp.Core.Domain.Entities;
using TodoApp.Core.Domain.IdentityEntities;

namespace TodoApp.Infrastructure.Database
{
    /// <summary>
    /// Configures the model for the database context, defining the schema and entity relationships.
    /// This method is called when the model for a derived context is being created.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ToDo> TodoData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasKey(t => t.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToDo>()
               .Property(t => t.Id)
               .ValueGeneratedOnAdd();
        }
    }
}
