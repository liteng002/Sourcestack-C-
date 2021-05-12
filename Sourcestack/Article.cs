using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Article : Content, Ichange
    {
        protected Article(string kind):base(kind)
        {
           
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
