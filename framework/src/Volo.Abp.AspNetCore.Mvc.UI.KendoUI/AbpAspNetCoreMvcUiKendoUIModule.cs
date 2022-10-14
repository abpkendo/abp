using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.AspNetCore.Mvc.UI.KendoUI;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AbpAspNetCoreMvcUiKendoUIModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiKendoUIModule>("Volo.Abp.AspNetCore.Mvc.UI.KendoUI");
        });
        context.AddKendoUIBundling();
        context.Services.AddKendo();
    }
}
