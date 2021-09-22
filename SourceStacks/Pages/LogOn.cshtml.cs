using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Article;

namespace SourceStacks.Pages
{
    public class LogOnModel : PageModel
    {
        public User NewUser { get; set; }
        public bool Rememberme { get; set; }
        public void OnGet()
        {
        }
    }
}
