using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lazy.Abp.BroadcastKit.Web.Menus
{
    public class BroadcastKitMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(BroadcastKitMenus.Prefix, displayName: "BroadcastKit", "~/BroadcastKit", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}