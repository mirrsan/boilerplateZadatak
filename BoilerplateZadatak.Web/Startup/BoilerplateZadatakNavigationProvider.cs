using Abp.Application.Navigation;
using Abp.Localization;

namespace BoilerplateZadatak.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class BoilerplateZadatakNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "Osoba",
                        L("Osoba"),
                        url: "Osoba",
                        icon: "fa fa-tasks")
                        .AddItem(
                            new MenuItemDefinition(
                                "Osoba",
                                L("Sve osobe"),
                                url: "Osoba",
                                icon: "fa fa-tasks"))
                        .AddItem(
                            new MenuItemDefinition(
                                "Osoba",
                                L("Dodaj novu osobu"),
                                url: "Osoba/NovaOsoba",
                                icon: "fa fa-tasks"))
                ).AddItem(
                    new MenuItemDefinition(
                        "Kancelarija",
                        L("Kancelarija"),
                        url: "Kancelarija",
                        icon: "fa fa-tasks")
                        .AddItem(
                            new MenuItemDefinition(
                                "Kancelarija",
                                L("Sve kancelarije"),
                                url: "Kancelarija",
                                icon: "fa fa-tasks"))
                        .AddItem(
                            new MenuItemDefinition(
                                "Kancelarija",
                                L("Dodaj novu kancelariju"),
                                url: "Kancelarija/NovaKancelarija",
                                icon: "fa fa-tasks"))
                ).AddItem(
                    new MenuItemDefinition(
                            PageNames.Uredjaj,
                            L("Uredjaj"),
                            url: "Uredjaj",
                            icon: "fa fa-tasks")
                        .AddItem(
                            new MenuItemDefinition(
                                "Uredjaj",
                                L("Svi Uredjaji"),
                                url: "Uredjaj",
                                icon: "fa fa-tasks"))
                        .AddItem(
                            new MenuItemDefinition(
                                "Uredjaj",
                                L("Dodaj novi uredjaj"),
                                url: "Uredjaj/NoviUredjaj",
                                icon: "fa fa-tasks"))
                ).AddItem(
                    new MenuItemDefinition(
                        "OsobaUredjaj",
                        L("OsobaUredjaj"),
                        url: "OsobaUredjaj",
                        icon: "fa fa-tasks")
                        .AddItem(
                            new MenuItemDefinition(
                                "OsobaUredjaj",
                                L("Svi Osoba-Uredjaj"),
                                url: "OsobaUredjaj",
                                icon: "fa fa-tasks"))
                        .AddItem(
                            new MenuItemDefinition(
                                "OsobaUredjaj",
                                L("Dodaj novi Osoba-Uredjaj"),
                                url: "OsobaUredjaj/NoviOsobaUredjaj",
                                icon: "fa fa-tasks"))
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerplateZadatakConsts.LocalizationSourceName);
        }
    }
}
