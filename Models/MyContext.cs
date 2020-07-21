using Microsoft.EntityFrameworkCore;
namespace WeddingPlanner.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base(options){}
        public DbSet<Planner> planners {get;set;}
        public DbSet<Wedding> wedders {get;set;}
        public DbSet<Guest> attendants{get;set;}
    }
}