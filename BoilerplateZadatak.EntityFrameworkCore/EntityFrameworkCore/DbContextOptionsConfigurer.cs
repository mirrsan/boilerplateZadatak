using Microsoft.EntityFrameworkCore;

namespace BoilerplateZadatak.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BoilerplateZadatakDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BoilerplateZadatakDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
