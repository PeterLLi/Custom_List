using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

namespace Custom_List
{

    public class MyList<T> : IEnumerable
    {

        public T[] myArray { get; set; }
        public int arrayCapacity { get; set; }
        public int count { get; set; }

        public MyList()
        {
            arrayCapacity = 1;
            count = 0;
            myArray = new T[arrayCapacity];
        }

        public void Add(T addItem)
        {
            myArray[count] = addItem;
            count++;
            AddMore(addItem);
        }

        public void AddMore(T addItem)
        {
            if (count >= arrayCapacity)
            {
                arrayCapacity += 1;
                T[] secondArray = new T[arrayCapacity];
                for (int i = 0; i < count; i++)
                {
                    secondArray[i] = myArray[i];
                }
                myArray = secondArray;
            }
        }

        public void Remove(T removeItem)
        {
            int maxLength = myArray.Length;

            //Set new array length
            T[] removeArray = new T[arrayCapacity];


            //Loop through new array and set it equal to the old array
            for (int i = 0; i < maxLength; i++)
            {
                //If the selected item is found, add the next item in the old array
                if (removeItem.Equals(myArray[i]))
                {
                    removeArray[i] = myArray[i + 1];
                }
                else
                {
                    //Set new array as the same as the old array
                    removeArray[i] = myArray[i];
                }
            }

            //Check for repeating values
            for (int j = 0; j < myArray.Length - 2; j++)
            {
                if (removeArray[j].Equals(removeArray[j + 1]))
                {
                    removeArray[j + 1] = removeArray[j + 2];
                }
                else if (removeArray[j + 1] == null)
                {
                    break;
                }
            }

            //Fill the old array with the new array
            myArray = removeArray;

            //Remove end of array
            object item = removeItem.GetType();
            if(removeItem.GetType().Equals(typeof(int)))
            {
                for (int i = arrayCapacity - 1; i > 0; i--)
                {
                    if (removeArray[i].Equals(0))
                    {
                        arrayCapacity -= 1;
                    }
                }
                Console.WriteLine(arrayCapacity);
            }

        }

        public T this[int index]{
            // throw exception of index is unavailable
            get{
                try
                {
                    return myArray[index];
                } catch(System.IndexOutOfRangeException ex) {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range", nameof(index), ex);
                    throw argEx;
                }
            }
            set{
                myArray[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in myArray)
            {
                // Lets check for end of list (its bad code since we used arrays)
                if (o == null)
                {
                    break;
                }

                // Return the current element and then on next function call 
                // resume from next element rather than starting all over again;
                yield return o;
            }
        }
    }
}
