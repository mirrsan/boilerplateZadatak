using BoilerplateZadatak.Configuration;
using BoilerplateZadatak.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoilerplateZadatak.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BoilerplateZadatakDbContextFactory : IDesignTimeDbContextFactory<BoilerplateZadatakDbContext>
    {
        public BoilerplateZadatakDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoilerplateZadatakDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BoilerplateZadatakConsts.ConnectionStringName)
            );

            return new BoilerplateZadatakDbContext(builder.Options);
        }
    }
}