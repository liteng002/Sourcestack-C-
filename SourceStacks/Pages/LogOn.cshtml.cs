using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;
using SourceStacks.Pages.Entities;
using System;
using System.Linq;

namespace SourceStacks.Pages
{
    [BindProperties]
    public class LogOnModel : PageModel
    {
        public User NewUser { get; set; }
        public bool Rememberme { get; set; }

        public UserRepository userRepositorie;
        public LogOnModel()
        {
            userRepositorie = new UserRepository();
        }

        public void OnGet()
        {
            Rememberme = true;
            ViewData["HasLogOn"] = Request.Cookies[Keys.UserId];
        }
        public void OnPost()
        {
			User user = userRepositorie.Get(1,1).Where(u => u.Name == NewUser.Name).SingleOrDefault();
			if (user == null)
			{
				ModelState.AddModelError("NewUser.Name", "* 用户名不存在");
			}
			else
			{
				if (user.Password != NewUser.Password)
				{
					ModelState.AddModelError("NewUser.Password", "* 用户名或者密码错误");
				}//else nothing
			}
			if (!ModelState.IsValid)
			{
				return;
			}//else nothing
			CookieOptions cookie = new CookieOptions();
			if (Rememberme)
			{
				cookie.Expires = DateTime.Now.AddDays(14);
			}//else nothing

			Response.Cookies.Append(Keys.UserId, user.Id.ToString(), cookie);


		}
    }
}
