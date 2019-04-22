using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateZadatak.Configuration;
using BoilerplateZadatak.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BoilerplateZadatak.Web.Startup
{
    [DependsOn(
        typeof(BoilerplateZadatakApplicationModule), 
        typeof(BoilerplateZadatakEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BoilerplateZadatakWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateZadatakWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BoilerplateZadatakConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BoilerplateZadatakNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BoilerplateZadatakApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateZadatakWebModule).GetAssembly());
        }
    }
}