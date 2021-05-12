using System;
using System.Collections.Generic;
using System.Text;



namespace Sourcestack
{
    sealed class User : ISendMessage, IChat  //1.让User类无法被继承
    {                                        //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
                                             //假设User类同时继承了ISendMessage和IChat，如何处理？  -- -- 显示使用哪个send
        public string _name;
        private string _passwodr;
        static string _LnvitedBy;

        public User(string name, string password) //每一个User对象一定有Name和Password赋值
        {
            _name = name;
            _passwodr = password;
        }

        public string name
        {
            get { return _name; }
            set
            {
                if (value == "admin")// 如果user.Name为“admin”，输入时修改为“系统管理员”
                {
                    _name = "系统管理员";
                }
                else
                {
                    _name = value;
                }
            }
        }
        public string _password        //1.user.Password在类的外部只能改不能读
        {
            set { }
        }


        public string Register()
        {
            return "";
        }
        public User(string name)
        {

        }
        public bool Login()
        {
            return true;
        }

        void ISendMessage.Send()
        {
            throw new NotImplementedException();
        }

        void IChat.Send()
        {
            throw new NotImplementedException();
        }

        public User()
        {

        }
    }
}
