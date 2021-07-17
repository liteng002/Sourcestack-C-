using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //添加一个新类ContentService，其中
    //如果发布Article，需要Article作者消耗一个帮帮币
    //如果发布Problem，需要消耗Problem作者其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币
    //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine("saved into db")代替。
    class ContentService
    {
        //有一个发布（Release()）方法：
        public virtual void Release() {
        
        
        }
    }
}
