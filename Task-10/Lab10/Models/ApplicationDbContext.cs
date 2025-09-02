using Lab10.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab10.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions
            <ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Post> Posts { set; get; }
            
    }
}
