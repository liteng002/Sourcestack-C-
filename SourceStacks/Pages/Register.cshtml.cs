using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Entities;
using SourceStacks.Pages;

namespace SourceStacks.Pages

{
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


        public void OnPost()
        {
            if (ConfirmPassword != NewUser.Password)
            {
                ModelState.AddModelError(nameof(ConfirmPassword), "* ������������벻һ��");
            }//else nothing

            User user = userRepositorie.Get(1, 1).Where(u => u.Name == NewUser.InvitedBy.Name).SingleOrDefault();

            if (user == null)
            {
                ModelState.AddModelError("NewUser.InviterBy.Name", "* û�и�������");
            }
            else
            {
                if (user.InviteCode != NewUser.InvitedBy.InviteCode)
                {
                    ModelState.AddModelError("NewUser.Inviterby.InvitationCode", "* ���������");
                }//else nothing
            }
            if (!ModelState.IsValid)
            {
                return;
            }//else nothing
        }

        public void OnGet()
        {

            if (!ModelState.IsValid)
            {
                return;
            }
            // User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);

            //NewUser.InvitedBy = invitedBy;
            //NewUser.Register();
            //userRepository.Save(NewUser);

        }
    }
}
