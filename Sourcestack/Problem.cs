using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Problem
    {

        static string _Title;
        static string _Body;
        public int _Reward;
        static string _PublishDateTime;
        internal string _Author;
        public string[] _keyword;

        public int reward
        {
            get { return _Reward; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("reward 不能为负数");   //3.problem.Reward不能为负数
                    return;
                }
                else
                {
                    _Reward = value;
                }
            }

        }
        public  int[] heip = new int[10];
        public string this[int index] //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        {
            get { return _keyword[index - 1]; }
            set { _keyword[index - 1] = value; }
        }

        public Problem()
        {

        }

        public static string Publish()

        {
            return "";

        }

    }
}
