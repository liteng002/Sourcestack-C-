using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.wwwroot
{
    class Repository//定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    {                //能实例就不要静态 
        private const int _VERSION = 1;//一个int类型的常量version
        private readonly string _Connection;//一个静态只读的字符串connection，以后可用于连接数据库


      //可以加两个方法 get，scve以后用于存取对象
      public int Get()
        {
            return -1;
        }
        public int Scve()
        {
            return -1;
        }
    }
}
