using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.KendoUI.Bundling;
public class KendoUIScriptBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add("/themes/kendoui/jquery.min.js");
        context.Files.Add("/themes/kendoui/kendo.all.min.js");
        context.Files.Add("/themes/kendoui/kendo.aspnetmvc.min.js");
    }
}
