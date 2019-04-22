using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateZadatak.Localization;

namespace BoilerplateZadatak
{
    public class BoilerplateZadatakCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BoilerplateZadatakLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateZadatakCoreModule).GetAssembly());
        }
    }
}