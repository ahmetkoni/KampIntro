using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[] items;
        //ctor yazarak public class adıyla aynı eşkilde geitrilir.
        public MyDictionary() { 
            items = new T[0]; 
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items=new T[tempArray.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;


        }
        public int lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
