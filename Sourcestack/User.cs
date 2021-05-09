using System;
using System.Collections.Generic;
using System.Text;
//没写
//设计一种方式，保证：
//每一个Problem对象一定有Body赋值
//每一个User对象一定有Name和Password赋值

namespace Sourcestack
{
    class User
    {

        public string _name;
        static string _LnvitedBy;
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
       

        public  string  Register()
        {
            return "";
        }
        public   User( string name)
        {

        }
        public   bool Login()
        {
            return true;
        }
        public User()
        {

        }
    }
}
