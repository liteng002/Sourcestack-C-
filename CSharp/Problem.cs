using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）和作者（Author）
    //观察一起帮的求助（Problem）抽象出一个父类：内容（Content）
    class Problem : Content, IClick
    {
        private string title;
        private string body;

        //每一个Problem对象一定有Body赋值
        public Problem(string Body, string king) : base(king) {
            this.body = Body;
        }

        //problem.Reward不能为负数
        private int reward;
        //修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常

        public int Reward
        {
            get {
                return reward;
            }
            set {
                if (reward < 0)
                {
                    //reward = value;
                    throw new ArrayTypeMismatchException($"参数越界{value}");
                }
                else
                {
                    Console.WriteLine("您的悬赏不能为负数");
                }
            }
        }

        public User Author
        {
            get; set;
        }

        public string Title
        {
            get;set;
        }

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] keyword = new string[10];
        public string this[int index]
        {
            get {
                return keyword[index - 1];
            }
            set {
                keyword[index - 1] = value;
            }
        }

        //添加一个新类ContentService，其中有一个发布（Release()）方法：
        //如果发布Problem，需要消耗Problem作者其设置悬赏数量的帮帮币
        public override void Release() {
            //需要消耗Problem作者其设置悬赏数量的帮帮币  怎么体现
            //Console.WriteLine("saved into db")
        }

        //将HelpMoneyChanged应用于Publish()方法
        [HelpMoneyChanged(10/*, Message = "发布"*/)]
        public void Publish() {
            Author.HelpMoney--;
        }


        void IClick.Agree() {

        }

        void IClick.Disagree() {

        }
    }
}
