using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;

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
