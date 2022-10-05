using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Bundling;

public class KendoUIThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        //remove all other files that added by the abp,kendo ui theme and the projects that used kendo ui theme will not use this files
        context.Files.Clear();
        context.Files.Add("/themes/kendoui/kendo.bootstrap-main.min.css");
    }
}
