using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }

}
