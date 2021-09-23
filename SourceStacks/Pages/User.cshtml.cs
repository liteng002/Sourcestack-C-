using System.ComponentModel.DataAnnotations;


namespace SourceStacks.Pages
{
	public class User : Entity
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public User InvitedBy { get; set; }
		public string ValidatePassword { get; set; }
		public string Captcha { get; set; }
		public int Age { get; set; }
		public string InviteCode { get; set; }
		public int BCredit { get; set; }

		public string QQ { get; set; }
		public string Wechat { get; set; }
		public string phone { get; set; }
		public string postscript { get; set; }

		public bool IsMale { get; set; }

		public void Register()
        {
			InvitedBy.BCredit += 10;
        }

	}
}
