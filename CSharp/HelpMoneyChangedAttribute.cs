﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //    自定义一个特性HelpMoneyChanged（帮帮币变化）：
    //该特性只能用于方法
    //有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
    //有一个string类型的Message属性，记录帮帮币变化的原因
    [AttributeUsage(AttributeTargets.Method)]
    class HelpMoneyChangedAttribute : Attribute
    {
        public HelpMoneyChangedAttribute(int amount) {
            Amount = amount;
        }

        public string Message
        {
            get;set;
        }
        public int Amount
        {
            get;set;
        }
    }
}
