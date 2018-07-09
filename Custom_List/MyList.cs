using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Custom_List
{

    public class MyList<T>
    {
        
        public T[] myArray { get; set; }
        public int arrayCapacity { get; set; }
        public int arrayCount { get; set; }

        public MyList()
        {
            arrayCapacity = 5;
            arrayCount = 0;
            myArray = new T[arrayCapacity];
        }

        public void Add(T addItem)
        {
            myArray[arrayCount] = addItem;
            arrayCount++;
            AddMore(addItem);
        }

        public void AddMore(T addItem)
        {
            if(arrayCount >= arrayCapacity){
                arrayCapacity += 5;
                T[] secondArray = new T[arrayCapacity];
                for (int i = 0; i < arrayCount; i++)
                {
                    secondArray[i] = myArray[i];
                }
                myArray = secondArray;
            }
        }

        public void Remove(T removeItem){
            int maxLength = myArray.Length;


            //Set new array length
            T[] removeArray = new T[arrayCapacity];

            //Loop through new array and set it equal to the old array
            for (int i = 0; i < maxLength; i++)
            {
                //Set new array as the same as the old array
                removeArray[i] = myArray[i];

                //If the selected item is found, add the next item in the old array
                if (removeItem.Equals(myArray[i]))
                {
                    removeArray[i] = myArray[i + 1];
                }
            }

            //Check for repeating numbers
            for (int j = 0; j < maxLength - 2; j++){
                if (removeArray[j].Equals(removeArray[j + 1]))
                {
                    removeArray[j + 1] = removeArray[j + 2];
                }
            }

            //Fill the old array with the new array
            myArray = removeArray;


        }

        public T this[int index]{
            get{
                return myArray[index];
            }
            set{
                myArray[index] = value;
            }
        }
    }
}
