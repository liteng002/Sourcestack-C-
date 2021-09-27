using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;
using SourceStacks.Pages.Filter;

namespace SourceStacks.Pages
{
    [NeedLogon]
    public class ContactModel : PageModel
    {
        public User NewUser { get; set; }
        public void OnGet()
        {
        }
    }
}
