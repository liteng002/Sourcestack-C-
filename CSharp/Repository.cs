using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //能实例就不要静态
    class Repository
    {


        //一个int类型的常量version
        private const int _Version = 0;
        //一个静态只读的字符串connection，以后可用于连接数据库
        private static readonly string _Connection;

        private int _Id;
        //根据Id从数据库获取一条求助
        public int Load(int id) {
            return -1;
        }
        //根据Id删除某个求助
        public int Delete(int id) {
            return -1;
        }
        //可用于在底层实现上述方法和数据库的连接操作等
        public Repository ID(Repository repository ) {
            return repository;
        }


        //发布一篇求助，并将其保存到数据库
        public bool Publish(Problem problem ) 
        {

            return true;
        } 



    }
}
