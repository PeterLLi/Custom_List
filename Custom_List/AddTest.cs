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
        public void AddTestFirst()
        {
            int expected = 1;
            list.Add(1);

            Console.WriteLine(list[0]);
            Assert.AreEqual(expected, list[0]);
        }

        [Test]
        public void SearchIndex(){
            
        }
    }
}
