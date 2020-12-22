using LazyAbp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LazyAbp.BroadcastKit.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BroadcastKitPageModel : AbpPageModel
    {
        protected BroadcastKitPageModel()
        {
            LocalizationResourceType = typeof(BroadcastKitResource);
            ObjectMapperContext = typeof(BroadcastKitWebModule);
        }
    }
}