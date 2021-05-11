using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Problem : Content
    {

        static string _Title { get; set; }
        static string _Body { get; set; }
        public int _Reward { get; set; }
        static string _PublishDateTime { get; set; }
        internal string _Author { get; set; }
        public string[] _keyword { get; set; }

        public Problem(string body, string kind) : base(kind)//每一个Problem对象一定有Body赋值
        {
            _Body = body;
        }

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
        public int[] heip = new int[10];
        public string this[int index] //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        {
            get { return _keyword[index - 1]; }
            set { _keyword[index - 1] = value; }
        }

      

        public string Publish() //1.：发布一篇求助，并将其保存到数据库
        {
            return "";

        }
        public bool Load(int id)//2.根据Id从数据库获取一条求助
        {
            return true;
        }
        public bool Delete(int id)//3.根据Id删除某个求助
        {
            return true;
        }
        string _repoistory;  //4.可用于在底层实现上述方法和数据库的连接操作等


    }
}
