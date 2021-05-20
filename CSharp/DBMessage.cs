using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("我存到了数据库");
        }
    }
}
