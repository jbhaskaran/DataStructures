using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Set
    {
        private int length;
        private Object[] setArray;
        private int capacity;

        public Set() : this(5)
        {
            
        }

        public Set(int initialCapacity)
        {
            this.length = 0;
            capacity = initialCapacity;
            setArray = new Object[initialCapacity];
        }

        public bool Contains(Object obj)
        {
            //for(int i = 0; i < length; i++)
            //{
            //    if(setArray[i] == obj)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return IndexOf(obj) != -1;
        }

        public void Add(Object obj)
        {
            if (length == capacity)
            {
                capacity = 2 * capacity;
                Object[] tempArray = new Object[capacity];
                Array.Copy(setArray, tempArray, length);
                setArray = tempArray;
            }
            if (!Contains(obj))
            {
                setArray[length++] = obj;
            }
        }

        private int IndexOf(Object value)
        {
            for(int i = 0; i < length; i++)
            {
                Object obj = setArray[i];
                if (obj !=null && obj.Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(Object obj)
        {
            //for(int i = 0; i < length; i++)
            //{
            //    if(setArray[i] == obj)
            //    {
            //        setArray[i] = null;
            //        length--;
            //    }
            //}
            int index = IndexOf(obj);
            if(index != -1)
            {
                //optimized copy
                //Array.Copy(this.setArray, index + 1, this.setArray, index, this.length - index);
                //setArray[index] = setArray[length];
                for (int j = index; j < length - 1; j++)
                {
                    setArray[j] = setArray[j + 1];
                }
            }
            length--;
            setArray[length] = null;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public int Size()
        {
            return length;
        }
    }
}
