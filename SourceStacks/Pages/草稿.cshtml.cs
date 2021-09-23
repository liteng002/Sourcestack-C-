using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DurableTask.Core.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStacks.Pages
{
    public class 草稿Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "飞哥";
        }
    }
}
