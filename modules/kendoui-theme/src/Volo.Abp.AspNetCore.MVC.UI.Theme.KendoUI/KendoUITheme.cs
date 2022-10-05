
using global::Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI;

[ThemeName(Name)]
public class KendoUITheme : ITheme, ITransientDependency
{
    public const string Name = "KendoUI";

    public virtual string GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case StandardLayouts.Application:
                return "~/Themes/KendoUI/Layouts/Application.cshtml";
            case StandardLayouts.Account:
                return "~/Themes/KendoUI/Layouts/Account.cshtml";
            case StandardLayouts.Empty:
                return "~/Themes/KendoUI/Layouts/Empty.cshtml";
            default:
                return fallbackToDefault ? "~/Themes/KendoUI/Layouts/Application.cshtml" : null;
        }
    }
}
