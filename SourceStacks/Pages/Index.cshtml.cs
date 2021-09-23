using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SourceStacks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SourceStacks.Pages
{
    public class IndexModel : PageModel
    {
        public Repositories repositories;
        public IList<Content> Articles { get; set; }
        public int Count { get; set; }
        public int PageSize = 2;
        public int PageIndex { get; set; }
        public IndexModel()
        {
            //repositories = new Repositories();
        }
        //public void OnGet()
        //{
        //    Count = repositories.GetCount();
        //    Articles = (IList<Content>)repositories.Get(PageIndex, PageSize);

        //}
    }
}
