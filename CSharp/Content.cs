using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），
    //根据他们的特点，抽象出一个父类：内容（Content）
    //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
    abstract class Content : ContentService
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        protected int _King;

        //确保每个Content对象都有kind的非空值
        protected Content(int king)
        {
            this._King = king;
        }
        //在构造函数里面赋值
        public Content(DateTime CreateTime)
        {
            this._CreateTime = CreateTime;
            this.PublishTime = PublishTime;
        }

        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //CreateTime 想一想他们应该在哪里赋值比较好，并完成相应代码
        private DateTime _CreateTime;
        public DateTime CreateTime
        {
            get { return _CreateTime; }
        }

        //PublishTime 想一想他们应该在哪里赋值比较好，并完成相应代码
        private DateTime PublishTime { get; }







    }
}
