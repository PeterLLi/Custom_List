using System;
using NUnit.Framework;

//Add one item
namespace Custom_List
{
    [TestFixture]
    public class AddTest
    {
        

        [Test]
        public void IntAddToTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Expected number to get
            int expected = 6;
            Console.WriteLine("Add test");

            //Add numbers to the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //Actualy number in the list
            int actual = list[5];

            //Compare expected and actual values
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        public void StringAddToTest(){
            
        }

        [Test]
        public void RemoveFromTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Add numbers to the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //Remove test
            Console.WriteLine("Remove test");
            int actual = list[0];
            list.Remove(1);

            Console.WriteLine("");
            Console.WriteLine("The new number is: ");
            Console.WriteLine(list[0]);


            for (int i = 0; i < list.arrayCapacity; i++){
                Console.WriteLine(list[i]);
            }
        }
    }
}
