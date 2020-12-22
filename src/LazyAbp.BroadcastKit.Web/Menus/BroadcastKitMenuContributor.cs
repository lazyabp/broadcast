using System.Threading.Tasks;
using LazyAbp.BroadcastKit.Localization;
using LazyAbp.BroadcastKit.Permissions;
using Volo.Abp.UI.Navigation;

namespace LazyAbp.BroadcastKit.Web.Menus
{
    public class BroadcastKitMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<BroadcastKitResource>();
            //Add main menu items.

            context.Menu.AddItem(
                new ApplicationMenuItem(BroadcastKitMenus.Broadcast, l["Menu:Broadcast"], "/BroadcastKit/Broadcast")
            );

            await Task.Delay(1);
        }
    }
}
