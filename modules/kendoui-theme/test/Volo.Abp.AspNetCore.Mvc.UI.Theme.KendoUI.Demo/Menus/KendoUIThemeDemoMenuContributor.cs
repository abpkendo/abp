using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Demo.Menus;


public class KendoUIThemeDemoMenuContributor : IMenuContributor
{
    public Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            AddMainMenuItems(context);
        }

        return Task.CompletedTask;
    }

    private void AddMainMenuItems(MenuConfigurationContext context)
    {
        var menuItem = new ApplicationMenuItem("Components", "Components");

        var items = new List<ApplicationMenuItem>()
            {
                new ApplicationMenuItem("Alerts", "Alerts", url: "/Components/Alerts"),
                new ApplicationMenuItem("Badges", "Badges", url: "/Components/Badges"),
            };

        items.OrderBy(x => x.Name)
             .ToList()
             .ForEach(x => menuItem.AddItem(x));

        context.Menu.AddItem(menuItem);

        var item2 = new ApplicationMenuItem("item2", "item2");
        var item21 = new ApplicationMenuItem("item21", "item21");
        var item211 = new ApplicationMenuItem("item211", "item211", url: "http://www.baidu.com");
        item21.AddItem(item211);
        item2.AddItem(item21);

        context.Menu.AddItem(item2);
    }
}

