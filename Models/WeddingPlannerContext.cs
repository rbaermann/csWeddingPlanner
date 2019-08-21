using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Models
{
    public class WeddingPlannerContext : DbContext
    {
        public WeddingPlannerContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get; set;}

        public DbSet<Wedding> Weddings {get; set;}

        public DbSet<UserWedding> UserWeddings {get; set;}
    }
}