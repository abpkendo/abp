using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.KendoUI.Bundling;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Mvc.UI.KendoUI;
public static class KendoUIBundling
{
    public const string KendoUIStyleBundleName = "KendoUiStyles";
    public const string KendoUIScriptBundleName = "KendoUiScripts";
    public static void AddKendoUIBundling(this ServiceConfigurationContext context)
    {
        context.Services.Configure<AbpBundlingOptions>(options =>
        {
            options.StyleBundles.Add(KendoUIStyleBundleName, bundle => { bundle.AddContributors(typeof(KendoUIStylesBundleContributor)); });
            options.ScriptBundles.Add(KendoUIScriptBundleName, bundle => { bundle.AddContributors(typeof(KendoUIScriptBundleContributor)); });
        });
    }
}
