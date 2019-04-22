using Abp.EntityFrameworkCore;
using BoilerplateZadatak.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateZadatak.EntityFrameworkCore
{
    public class BoilerplateZadatakDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Kancelarija> Kancelarije { get; set; }
        public DbSet<Uredjaj> Uredjaj { get; set; }
        public DbSet<OsobaUredjaj> OsobaUredjaj { get; set; }

        public BoilerplateZadatakDbContext(DbContextOptions<BoilerplateZadatakDbContext> options) 
            : base(options)
        {

        }
    }
}
