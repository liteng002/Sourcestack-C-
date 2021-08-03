using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    //出栈Pop()，弹出栈顶数据
    //入栈Push()，可以一次性压入多个数据
    //出/入栈检查，
    //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
    //如果已弹出所有数据，提示“栈已空”
    //使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素
    class MimicStack
    {
        private const int _Top = 0;
        private const int _Bottom = 0;
        private int[] _Array = new int[10];

        public void Pop() { 
        
        }

        public void Push() { 
        
        }


    }
}
