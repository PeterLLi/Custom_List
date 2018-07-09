using System;
using NUnit.Framework;
using System.Collections.Generic;

//Add one item
namespace Custom_List
{
    [TestFixture]
    public class AddTest
    {
        MyList<int> list = new MyList<int>();

        [Test]
        public void AddToTest()
        {
            
            int expected = 6;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            int actual = list[5];
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [Test]
        public void RemoveFromTest()
        {
            int expected = 0;
            int actual = list[0];
            list.Remove(1);
        }
    }
}
