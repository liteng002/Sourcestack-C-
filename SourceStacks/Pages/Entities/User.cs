using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Entities
{
    public class User : Entity
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "* 用户名不能为空")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "* 长度至少4位")]
        public string Password { get; set; }
        //[Required(ErrorMessage = "* 邀请人不能为空")]
        public User InvitedBy { get; set; }
        public string ValidatePassword { get; set; }
        public string Captcha { get; set; }
        public int Age { get; set; }
        //[StringLength(4, MinimumLength = 4, ErrorMessage = "* 长度只能为4")]
        public string InviteCode { get; set; }
        public int BCredit { get; set; }

        public string QQ { get; set; }
        public string Wechat { get; set; }
        public string phone { get; set; }
        public string postscript { get; set; }

        public bool IsMale { get; set; }

        //public void Register()
        //{
        //    InvitedBy.BCredit += 10;
        //}
    }
}
