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
            get { return _Totle  ; }
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
            set { _PublishDateTime = value ;}
                
        }


        
        private string _Repository;//repository：可用于在底层实现上述方法和数据库的连接操作等
        public string Repository
        {
            get { return  ""; }
            set { }
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









        public  int Publish()//考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中： 
        {                    //Publish()：发布一篇求助，并将其保存到数据库
            return -1; 
        }

        public int Load(int id)//Load(int Id)：根据Id从数据库获取一条求助
        {
            return -1;
        }
        public int Delete(int id)//Delete(int Id)：根据Id删除某个求助
        {
            return -1;
        }

       



    }
}
