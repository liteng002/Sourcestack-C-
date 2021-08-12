using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。
    //改造Entity类，让其Id可以为任意类型
    class Entity<T>
    {
        protected int _Id ;
        public int Id 
        {
            get { return _Id; }

        }
    }
}
