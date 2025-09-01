using Lab09.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab09.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
