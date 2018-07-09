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
