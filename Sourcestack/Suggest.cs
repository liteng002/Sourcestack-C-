using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Suggest : Content, Ichange
    {
        protected Suggest(string kind) : base(kind)
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
}
