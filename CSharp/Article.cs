using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //观察一起帮的文章（Article）抽象出一个父类：内容（Content）
    class Article : Content, IClick
    {

        public Article(int king) : base(king) {

        }

        //添加一个新类ContentService，其中有一个发布（Release()）方法：
        //如果发布Article，需要Article作者消耗一个帮帮币
        public override void Release() {
            //需要Article作者消耗一个帮帮币  怎么体现？
            Console.WriteLine("saved into db");
        }

        //一篇文章可以有多个评论
        public List<Comment> Contents   {   get; set;  }

        //每个文章和评论都有一个评价
        public Appraise Appraise {  get; set;    }

        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
           public List<Keyword> keywords { get;set;    }
        public List<Comment> Comments
        {
            get;
            internal set;
        }
        public string Title
        {
            get;
            internal set;
        }
        public object Name
        {
            get;
            internal set;
        }

        void IClick.Agree() {

        }

        void IClick.Disagree() {

        }

        public static implicit operator Article(Article v) {
            throw new NotImplementedException();
        }
    }
}
