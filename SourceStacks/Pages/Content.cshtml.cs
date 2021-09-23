using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Dom;
using Google.Api.Ads.AdWords.v201809;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Documents;




namespace SourceStacks.Pages
{
    public class Content : Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Answer { get; set; }
        public int Summary { get; set; }
        public int Reward { get; set; }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        public IList<Keyword> keywords { get; set; }

        public void OnGet()
        {
        }
    }
}
