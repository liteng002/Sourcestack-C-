using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Article;


namespace SourceStacks.Pages
{
    public class ContactModel : PageModel
    {
        public User NewUser { get; set; }
        public void OnGet()
        {
        }
    }
}
