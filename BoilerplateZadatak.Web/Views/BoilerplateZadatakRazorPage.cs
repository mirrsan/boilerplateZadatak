using Abp.AspNetCore.Mvc.Views;

namespace BoilerplateZadatak.Web.Views
{
    public abstract class BoilerplateZadatakRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BoilerplateZadatakRazorPage()
        {
            LocalizationSourceName = BoilerplateZadatakConsts.LocalizationSourceName;
        }
    }
}
