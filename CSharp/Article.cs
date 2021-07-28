using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //观察一起帮的文章（Article）抽象出一个父类：内容（Content）
    class Article : Content , IClick
    {
        public Article(int king) : base(king)
        {

        }

        //添加一个新类ContentService，其中有一个发布（Release()）方法：
        //如果发布Article，需要Article作者消耗一个帮帮币
        public override void Release()
        {
            //需要Article作者消耗一个帮帮币  怎么体现？
                    Console.WriteLine("saved into db");
        }

        void IClick.Agree()
        {
           
        }

        void IClick.Disagree()
        {
            
        }
    }
}
