using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //观察一起帮的意见建议（Suggest）抽象出一个父类：内容（Content）
    class Suggest : Content
    {
        public Suggest(int king) : base(king)
        {

        }


        //添加一个新类ContentService，其中有一个发布（Release()）方法：
        //如果发布Suggest，不需要消耗帮帮币
        public override void Release()
        {
            //不需要消耗帮帮币  怎么体现
            Console.WriteLine("saved into db")
        }


    }
}
