using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class User
    {

        //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        private string _Name;
        public string Name//如果user.Name为“admin”，输入时修改为“系统管理员”
        {                 //设计一种方式，保证：每一个User对象一定有Name和Password赋值
            get { return _Name; }
            set
            {
                if (value == "admin")
                {
                    _Name = "系统管理员";
                }
                else
                {
                    _Name = value + _Password;

                }
            }
        }
        private string _Password;//user.Password在类的外部只能改不能读
        public string Password { private get { return _Password; } set { _Password = value; } }
        private string _InvitedBy;
        public string InvitedBy
        {
            get { return _InvitedBy + _Name + _Password; }
            set { _InvitedBy = value + _Name + _Password; }
        }





        

        public User()
        {

        }






        public static bool Register()
        {
            return false;
        }

        public static bool Login()
        {
            return false;
        }
    }
}
