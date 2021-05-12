using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Suggest : ContentService, Ichange
    {
        protected Suggest(string kind) 
        {

        }
        public override  void Publish()
        {
            Console.ReadLine();
            Console.WriteLine("不需要消耗帮帮币");
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

