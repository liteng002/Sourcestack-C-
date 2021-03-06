using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Pages.Entities;

namespace SourceStacks.Pages
{
    public class LogOffModel : PageModel
    {
        public IActionResult OnGet()
        {
            //Response.Cookies.Delete(Keys.UserId);
            //return RedirectToPage("/Log/On");
            //HttpContext.Session.Remove(Keys.Status);
            HttpContext.Session.Clear();
            return Redirect(Request.Headers["referer"]);
        }
    }
}
