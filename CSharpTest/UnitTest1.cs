using NUnit.Framework;
using Sourcestack;

namespace CSharpTest
{
    public class UnitTest
    {
        private Unit node1, node2, node3, node4;

        [SetUp]
        public void Setup()
        {
            node1 = new Unit();
            node2 = new Unit();
            node3 = new Unit();
            node4 = new Unit();
            node1.next = node2;
            node2.previous = node1;
            node2.next = node3;
            node3.previous = node2;
            node3.next = node4;
            node4.previous = node3;
        }
        [Test]
        public void AddAfter() //往最后加一个  1 2 3 4  [5]
        {
            Unit node5 = new Unit();
            node4.AddAfter(node5);
            Assert.IsNull(node1.previous);
            Assert.AreEqual(node4, node5.previous);
            Assert.AreEqual(node5, node4.next);
            Assert.IsNull(node5.next);
        }

        [Test]
        public void AddAfters()//中间插一个   1 2 [5]3 4 
        {
            Unit node5 = new Unit();
            node2.AddAfter(node5);
            Assert.IsNull(node1.previous);
            Assert.AreEqual(node2, node5.previous);
            Assert.AreEqual(node5, node2.next);
            Assert.AreEqual(node5, node3.previous);
            Assert.AreEqual(node3, node5.next);
            Assert.IsNull(node4.next);
        }
        [Test]
        public void Delete()   //删除  1 [2] 3 4 
        {
            node1.Delete(node2);
            Assert.IsNull(node1.previous);
            Assert.AreEqual(node1, node3.previous);
            Assert.AreEqual(node3,node1.next);
            Assert.IsNull(node4.next);          
        }

        [Test]
        public void Swap() //交互两个节点  [1] 2 [3] 4  // 没做出来
        {                            //   [3] 2 [1] 4



            Assert.IsNull(node3.previous);
            Assert.AreEqual(node3,node2.previous);
            Assert.AreEqual(node2,node3.next);
            Assert.AreEqual(node2,node1.previous);
            Assert.AreEqual(node1,node2.next);
            Assert.AreEqual(node4,node1.next);
            Assert.IsNull(node4.next);

        }


















        //[Test]
        //public void Greet()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //public void GuessMe()
        //{
        //    Program.GuessMe(); 
        //}


    }
}