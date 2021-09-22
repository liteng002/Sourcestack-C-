using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Article
{
	public class User : Entity
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
