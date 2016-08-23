using Microsoft.EntityFrameworkCore;

namespace Bamboo.Models
{
    public class BambooContext : DbContext
    {
        public BambooContext(DbContextOptions<BambooContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=Bamboo;Trusted_Connection=True;");
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
