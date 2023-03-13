using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alimbio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Alimbio.Models.Entreprise> Entreprises { get; set; }
        public DbSet<Alimbio.Models.Salarie> Salaries { get; set; }
        public DbSet<Alimbio.Models.Site> Sites { get; set; }
        public DbSet<Alimbio.Models.Service> Services { get; set; }
        public DbSet<Alimbio.Models.Ville> Villes { get; set; }
 




    }
}