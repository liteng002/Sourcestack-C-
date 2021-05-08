using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    class Problem
    {
        
        static string _Title;
        static string _Body;
        public int _Reward;
        static string _PublishDateTime;
        internal string _Author;
        public int reward
        {
            get { return _Reward; }
            set
            {
                if (value <= 0 )
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


        public static string Publish()

        {
            return "";

        }

    }
}
