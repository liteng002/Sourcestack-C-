using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{    //没做
    //实例化文章和意见建议，调用他们：
    //继承自父类的属性和方法
    //自己的属性和方法



    //1.观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    public class Content
    {
        /*protected*/
        private string _kind;//Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        private string _createTime;
        protected Content(string kind)//确保每个Content对象都有kind的非空值
        {
            _kind = kind;

        }

        private Content(int PublishTime) //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        {

        }

        public void releast()
        {

        }


    }
}
