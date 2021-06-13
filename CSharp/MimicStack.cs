using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    //出栈Pop()，弹出栈顶数据
    //入栈Push()，可以一次性压入多个数据
    //出入栈检查 栈溢出和栈已空
    //chuan构造，索引器，还是属性
    class MimicStack
    {
        private int _Pop = 0;
        private int _Push = 0;
       
        private int _Element;
        public int Element {
            get { return _Element; }
            set{ _Element = value; }
        }

        private int[] _Array;
       
       
        public MimicStack(int length)
        {
           _Array = new int  [length];
        }

       
        public MimicStack(int length, int twoEiement)
            :this(length)
        {
            this._Element = twoEiement;
        }
        public MimicStack(int oneEiement, int twoEiemeent, int threeEiement)
        : this(oneEiement,twoEiemeent)
        {
            this._Element = threeEiement;
        }


        public int PushStack(int _Element )
        {

            
            if (_Push <= _Array.Length)
            {
                _Array[_Push] = _Element;
                _Push++;
            }
            else
            {
               Console.WriteLine("溢出");
                return -1;
            }
                return -1;
                    }

        public int PopStack( )

        {
            if (_Push == _Array.Length)
            {
                _Push--;
            }
            else if (_Push >  _Array.Length)
            {
                Console.WriteLine("空");
                return -1;
            }
            return -1;
        }




       
        }

    }
