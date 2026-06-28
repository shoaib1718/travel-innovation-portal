using Microsoft.EntityFrameworkCore;
using TravelInnovationPortal.Models;

namespace TravelInnovationPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}