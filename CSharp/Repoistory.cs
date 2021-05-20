using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    class Repoistory : Entity //能实例就不要静态
    {
        const int _version = 0; //1.一个int类型的常量version
        public static readonly string connection; //2.一个静态只读的字符串connection，以后可用于连接数据库

        string get()
        {
            return "";
        }
        string set()
        {
            return "";
        }
    }

}
