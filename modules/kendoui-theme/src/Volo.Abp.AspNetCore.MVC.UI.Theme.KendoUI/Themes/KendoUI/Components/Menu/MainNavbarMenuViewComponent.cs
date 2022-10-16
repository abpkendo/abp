using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;
using Kendo.Mvc.UI;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Themes.KendoUI.Components.Menu;
public class MainNavbarMenuViewComponent : AbpViewComponent
{
    protected IMenuManager MenuManager { get; }

    public MainNavbarMenuViewComponent(IMenuManager menuManager)
    {
        MenuManager = menuManager;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuManager.GetMainMenuAsync();
        var items = ConvertToPanelBarItems(menu.Items);
        return View("~/Themes/KendoUI/Components/Menu/Default.cshtml", items);
    }
    public List<PanelBarItemModel> ConvertToPanelBarItems(ApplicationMenuItemList items)
    {
        var result = new List<PanelBarItemModel>();
        foreach (var item in items)
        {
            var model = new PanelBarItemModel
            {
                Id = item.ElementId,
                Enabled = !item.IsDisabled,
                Text = item.DisplayName,
                Url = item.Url,
                Items = ConvertToPanelBarItems(item.Items)
            };
            result.Add(model);
        }
        return result;
    }
}
