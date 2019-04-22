using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateZadatak
{
    [DependsOn(
        typeof(BoilerplateZadatakCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerplateZadatakApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateZadatakApplicationModule).GetAssembly());
        }
    }
}