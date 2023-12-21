using Microsoft.EntityFrameworkCore;
using WebApi8.FisstApp.Models;
using WebApi8.FisstApp.Models.Converters;

namespace WebApi8.FisstApp.Database
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // convertors 
            var jsonObjConverter = new JsonObjectConverter<SubTask>();

            builder.Entity<Todo>()
                .Property(t => t.SubTask)
                .HasConversion(jsonObjConverter);
        }
        
    }
}
