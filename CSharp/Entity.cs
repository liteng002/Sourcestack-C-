using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。
    class Entity
    {
        protected int _Id;
        public int Id
        {
            get { return _Id; }

        }
    }
}
