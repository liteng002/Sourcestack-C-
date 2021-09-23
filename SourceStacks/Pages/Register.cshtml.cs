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
        private UserRepository userRepository;
        public RegisterModel()
        {
            userRepository = new UserRepository();
        }
        public User NewUser { get; set; }
        public string ConfirmPassword { get; set; }


        public void OnPost()
        {

        }

        public void OnGet()
        {
           // User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);

            //NewUser.InvitedBy = invitedBy;
            //NewUser.Register();
            //userRepository.Save(NewUser);

        }
    }
}
