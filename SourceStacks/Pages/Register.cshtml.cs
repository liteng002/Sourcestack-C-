using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Pages.Article;


namespace MyWebApp.Pages

{
    public class RegisterModel : PageModel
    {
        public User NewUser { get; set; }

        public void OnGet()
        {

        }
    }
}
