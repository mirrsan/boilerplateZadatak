using Abp.Application.Services;

namespace BoilerplateZadatak
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BoilerplateZadatakAppServiceBase : ApplicationService
    {
        protected BoilerplateZadatakAppServiceBase()
        {
            LocalizationSourceName = BoilerplateZadatakConsts.LocalizationSourceName;
        }
    }
}