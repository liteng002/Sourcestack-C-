using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStacks.Pages
{
    public class 草稿Model : PageModel
    {
        public string Name { get; set; } 
        public void OnGet()
        {
            Name = "飞哥";
        }
    }
}
