using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Demo;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Demo;

//[DependsOn(
//    typeof(AbpAspNetCoreMvcUIKendoUIThemeModule),
//    typeof(AbpAspNetCoreMvcUiThemeSharedDemoModule),
//    typeof(AbpAutofacModule)
//    )]
public class KendoUIThemeDemoModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var env = context.Services.GetHostingEnvironment();

        if (env.IsDevelopment())
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.ReplaceEmbeddedByPhysical<AbpAspNetCoreMvcUiThemeSharedDemoModule>(Path.Combine(env.ContentRootPath, string.Format("..{0}..{0}..{0}..{0}framework{0}src{0}Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Demo", Path.DirectorySeparatorChar)));
            });
        }

        Configure<AbpBundlingOptions>(options =>
        {
            options.StyleBundles
                .Get(StandardBundles.Styles.Global)
                .AddFiles("/demo/styles/main.css");
        });

        //Configure<AbpNavigationOptions>(options =>
        //{
        //    options.MenuContributors.Add(new KendoUIThemeDemoMenuContributor());
        //});
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var test = context.ServiceProvider.GetService<IVirtualFileProvider>();
        test.GetDirectoryContents("Themes");
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();
        app.UseConfiguredEndpoints();
    }
}
