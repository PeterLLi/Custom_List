using System;
using System.Collections;
using NUnit.Framework;

//Add one item
namespace Custom_List
{
    [TestFixture]
    public class AddTest
    {

        [Test]
        public void IntAddTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Expected number to get
            int expected = 6;
            Console.WriteLine("Add test");

            //Populate the list
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

        [Test]
        public void StringAddTest()
        {
            
            //Generate a list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");

            for (int i = 0; i < list.arrayCapacity; i++)
            {
                Console.WriteLine(list[i]);
            }

            string expected = "One";
            string actual = list[0];
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StringRemoveTest()
        {
            //Generate a list of strings
            MyList<string> list = new MyList<string>();

            //Populate the list
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");

            //Remove from list test
            Console.WriteLine("Remove test");
            list.Remove("One");

            Console.WriteLine("");
            Console.WriteLine("The new first number is: ");
            Console.WriteLine(list[0]);

            Console.WriteLine("");
            Console.WriteLine("New list");
            for (int i = 0; i < list.arrayCapacity; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        [Test]
        public void IntRemoveTest()
        {
            //Generate a new list of integers
            MyList<int> list = new MyList<int>();

            //Populate the list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //Remove from list test
            Console.WriteLine("Remove test");
            int actual = list[0];
            list.Remove(1);

            Console.WriteLine("");
            Console.WriteLine("The new first number is: ");
            Console.WriteLine(list[0]);

            Console.WriteLine("");
            Console.WriteLine("New list");
            for (int i = 0; i < list.arrayCapacity; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    [TestFixture]
    public class Iterator
    {
        MyList<string> weekDayList;

        [Test]
        public void Loop()
        {
            weekDayList = new MyList<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            foreach (string element in weekDayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
