using System;
using System.Collections.Generic;
using System.Text;


//注册 / 登录功能，定义一个User类（以下所有类都按“一个类文件一个类”的原则组织），包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：
//Register()：能输出当前用户的注册信息，比如：fg开始注册，密码：1234，邀请人：dk
//Login()：能输出当前用户的登录信息，比如：fg开始登录，输入密码：1234

//每发布一个求助，该求助作者的帮帮币应该根据其悬赏金额予以冻结，这个过程应该实现在哪个类的哪个方法里面？

namespace CSharp
{
    //定义一个User类
    //让User类无法被继承
    //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。
    //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
    //假设User类同时继承了ISendMessage和IChat，如何处理？
    sealed class User : Entity , ISendMessage,  IChat
    {
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string name;
        //User类中添加一个Tokens属性，类型为TokenManager
        public TokenManager Tokens { get; set; }
        public string Name
        {
            get { return name; }
            set {
                if (value == "admin")
                {
                    name = "系统管理员";
                }//else nothing
                name = value;
            }
        }

        //user.Password在类的外部只能改不能读
        private string password;
        public string Password
        {
            
            set { password = value; }
        }

        private User invitedBY;

        //能输出当前用户的注册信息，比如：fg开始注册，密码：1234，邀请人：dk
        public string Register()
        {
            return "";
        }
        //能输出当前用户的登录信息，比如：fg开始登录，输入密码：1234
        public string Login()
        {
            return "";
        }

        void ISendMessage.Send()
        {
            throw new NotImplementedException();
        }

        void IChat.Send()
        {
            throw new NotImplementedException();
        }

        //每一个User对象一定有Name和Password赋值
        public User(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }

    }
}
