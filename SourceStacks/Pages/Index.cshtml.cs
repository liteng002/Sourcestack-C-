using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SourceStacks.Pages
{
    [NeedLogOn]
    public class IndexModel : PageModel
    {
        public Repositories.Repositories repositories;
        public IList<SourceStacks.PagesContent> Articles { get; set; }
        public int Count { get; set; }
        public int PageSize = 2;
        public int PageIndex { get; set; }
        public IndexModel()
        {
            repositories = new Repositories.Repositories();
        }
        public void OnGet()
        {
            Count = repositories.GetCount();
            Articles = repositories.Get(PageIndex, PageSize);

        }
    }
}
