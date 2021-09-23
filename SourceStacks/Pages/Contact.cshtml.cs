using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;

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
