using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateZadatak.EntityFrameworkCore
{
    [DependsOn(
        typeof(BoilerplateZadatakCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BoilerplateZadatakEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateZadatakEntityFrameworkCoreModule).GetAssembly());
        }
    }
}