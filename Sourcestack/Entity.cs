﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Entity // 再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？

    {
        private User _Id;
        internal int  id
        {
            get;
        }

    }
}