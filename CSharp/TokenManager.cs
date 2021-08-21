using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //声明一个令牌管理（TokenManager）类：
    class TokenManager
    {
        //使用私有的Token枚举_tokens存储所具有的权限
        private Token tokens;

        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
        public void Add(Token token)
        {
            this.tokens = this.tokens | token;
        }
        public void Remove(Token token)
        {
            if (Has(token))
            {
                this.tokens = this.tokens ^ token;
            }
            else
            {
                Console.WriteLine("没有此权限");
            }
        }
    

        public bool Has(Token token)
        {
            return token == (tokens & token);
        }
    }
}
