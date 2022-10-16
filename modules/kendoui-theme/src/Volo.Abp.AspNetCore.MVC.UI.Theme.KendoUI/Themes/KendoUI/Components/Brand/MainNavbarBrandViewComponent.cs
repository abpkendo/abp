using Microsoft.AspNetCore.Mvc;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Themes.KendoUI.Components.Brand;
public class MainNavbarBrandViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/KendoUI/Components/Brand/Default.cshtml");
    }
}
