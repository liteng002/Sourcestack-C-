using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;
using SourceStacks.Pages;
using SourceStacks.Pages.Entities;

namespace SourceStacks.Pages

{
    [BindProperties]
    public class RegisterModel : PageModel
    {

        private UserRepository userRepositorie;
        public RegisterModel()
        {
            userRepositorie = new UserRepository();
        }
        public User NewUser { get; set; }
        public string ConfirmPassword { get; set; }

        public string HomUrl { get; set; }


        public IActionResult OnPost()
        {
            if (ConfirmPassword != NewUser.Password)
            {
                ModelState.AddModelError(nameof(ConfirmPassword), "* 两次输入的密码不一致");
                TempData[Keys.ErrorMessage] = GetErrorMessage();
            }//else nothing

            User user = userRepositorie.Get(1, 1).Where(u => u.Name == NewUser.InvitedBy.Name).SingleOrDefault();

            if (user == null)
            {
                ModelState.AddModelError("NewUser.InviterBy.Name", "* 没有该邀请人");
                TempData[Keys.ErrorMessage] = GetErrorMessage();
            }
            else
            {
                if (user.InviteCode != NewUser.InvitedBy.InviteCode)
                {
                    ModelState.AddModelError("NewUser.Inviterby.InvitationCode", "* 邀请码错误");
                    TempData[Keys.ErrorMessage] = GetErrorMessage();

                }//else nothing
            }
            if (!ModelState.IsValid)
            {
                return RedirectToPage();
            }//else nothing
            return Page();
        }

        public object GetErrorMessage()
        {
            return ModelState.Where(m => m.Value.Errors.Any())
                .ToDictionary(
                m => m.Key, m => m.Value.Errors
                   .Select(s => s.ErrorMessage)
                   .FirstOrDefault(s => s != null)
                );
        }
        public void OnGet()
        {

            IDictionary<string, string> error = TempData[Keys.ErrorMessage] as Dictionary<string, string>;
            if (error != null)
            {
                foreach (var item in error)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }//else nothing

        }
    }
}
