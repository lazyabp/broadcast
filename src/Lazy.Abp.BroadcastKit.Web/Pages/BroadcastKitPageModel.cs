using Lazy.Abp.BroadcastKit.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Lazy.Abp.BroadcastKit.Web.Pages
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