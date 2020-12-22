using System.Threading.Tasks;

namespace LazyAbp.BroadcastKit.Web.Pages.BroadcastKit.Broadcast
{
    public class IndexModel : BroadcastKitPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
