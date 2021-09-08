using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Keyword
    {
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public string KeywordName   {get;set;  }
        public List<Article> Articles  { get;set;   }
    }
}
