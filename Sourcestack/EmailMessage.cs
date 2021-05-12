using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("我发布了一封Email");
        }
    }
}
