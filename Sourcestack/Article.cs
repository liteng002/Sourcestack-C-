using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Article : ContentService, Ichange
    {
        protected Article(string kind)
        {
           
        }
        public override   void Publish()
        {
            Console.ReadLine();
            Console.WriteLine("需要消耗一个帮帮币");
        }

        void Ichange.Agree()
        {
            throw new NotImplementedException();
        }

        void Ichange.Disagree()
        {
            throw new NotImplementedException();
        }
    }
}
