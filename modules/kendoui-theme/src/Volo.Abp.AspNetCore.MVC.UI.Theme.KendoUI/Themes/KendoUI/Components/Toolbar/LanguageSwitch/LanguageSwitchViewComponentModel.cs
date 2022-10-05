using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.KendoUI.Themes.KendoUI.Components.Toolbar.LanguageSwitch;
public class LanguageSwitchViewComponentModel
{
    public LanguageInfo CurrentLanguage { get; set; }

    public List<LanguageInfo> OtherLanguages { get; set; }
}
