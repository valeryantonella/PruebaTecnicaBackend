namespace PruebaTecnicaBIT.Data
{
using Microsoft.EntityFrameworkCore;
    using PruebaTecnicaBIT.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
