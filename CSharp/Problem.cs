using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Problem
    {
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()

        private string _Totle;
        public string Totle
        {//设计一种方式，保证：每一个Problem对象一定有Body赋值   
            get { return _Totle + _Body ; }
            set { _Totle = value + _Body;  } 
        }
        public string _Body { get; set; }
        private int _Reward;
        public int Reward//problem.Reward不能为负数
        {
            get { return    _Reward; }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("悬赏不能为负数");
                    _Reward = value;
                }//else
            }
        }
        private DateTime _PublishDateTime;
        public DateTime PublishDatetime{
            get { return _PublishDateTime; }
            set { _PublishDateTime = value; }
                
        }
        private string _Author;
        public string Authhor
        { get { return _Body + _Author; }
            set { _Author = value + _Body; }
        }
        private string[] _keyword;
        public string this[int index]
        {
            get { return _keyword[index]; }
            set { _keyword[index] = value; }
        }








        public Problem(int length)
        {
            _keyword = new string[length];
        }









        public static bool Publish()
        {
            return false;
        }



    }
}
