using System;
using System.Collections.Generic;
using System.Text;

namespace Sourcestack
{
    public class Unit
    {
        public Unit previous { get; set; }
        public Unit next { get; set; }


        /// <summary>
        /// 把node插入到this之后
        /// </summary>
        /// <param name="node"></param>
        public void AddAfter(Unit node)//最后加一个
        {
            Unit temp = this.next;
            this.next = node;
            node.previous = this;
            node.next = temp;
            if (temp != null)  //还是不明白这个null的意思
            {
                temp.previous = node;
        }
    }

        public void AddAfters(Unit node)  //中间插一个   1 2 [5]3 4 
        {

            Unit temp = this.next;
            this.next = node;
            node.previous = this;
            node.next = temp;
            temp.previous = node;
        }

        public void Delete(Unit node)   //删除 1 [2] 3 4 
        {
            Unit temp = node.next;
            this.next = temp;
            temp.previous = this;
        }
        public void SWAP(Unit node)   //交互两个节点   [1] 2 [3] 4
        {                              //             [3] 2 [1] 4           

            Unit temp = this.next;
            this.next = this.previous;
            this.previous = temp;
        }



    }
}
