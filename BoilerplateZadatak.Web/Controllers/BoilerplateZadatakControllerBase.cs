using Abp.AspNetCore.Mvc.Controllers;

namespace BoilerplateZadatak.Web.Controllers
{
    public abstract class BoilerplateZadatakControllerBase: AbpController
    {
        protected BoilerplateZadatakControllerBase()
        {
            LocalizationSourceName = BoilerplateZadatakConsts.LocalizationSourceName;
        }
    }
}