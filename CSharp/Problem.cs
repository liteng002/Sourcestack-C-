using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）和作者（Author）
    //观察一起帮的求助（Problem）抽象出一个父类：内容（Content）
    class Problem : Content, IClick
    {
        private string _Title;
        private string _Body;

        //每一个Problem对象一定有Body赋值
        public Problem(string Body,int king) :base(king)
        {
            this._Body = Body;
        }

        //problem.Reward不能为负数
        private int _Reward;
        public int Reward 
        {
            get { return _Reward; }
            set {
                if (Reward >= 0)
                {
                    Reward = value;
                }
                else
                {
                    Console.WriteLine("您的悬赏不能为负数");
                }
            }
        }

                private User _Author;

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] _Keyword = new string[10];
        public string this[int index]
        {
            get { return _Keyword[index - 1] ; }
            set { _Keyword[index - 1] = value; }
        }

        //添加一个新类ContentService，其中有一个发布（Release()）方法：
        //如果发布Problem，需要消耗Problem作者其设置悬赏数量的帮帮币
        public override void Release()
        {
            //需要消耗Problem作者其设置悬赏数量的帮帮币  怎么体现
            //Console.WriteLine("saved into db")
        }

        void IClick.Agree()
        {
            
        }

        void IClick.Disagree()
        {
            
        }
    }
}
