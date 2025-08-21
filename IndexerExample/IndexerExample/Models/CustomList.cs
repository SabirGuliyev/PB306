using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample.Models
{
    internal class CustomList<T> 
    {
        private T[] arr;


        public T this[int index]
        {
            get
            {
                if (arr.Length > index)
                {
                    return arr[index];
                }

                return arr[arr.Length - 1];
              
            }
            set
            {
                arr[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
        public int Capacity { get; set; } = 0;

        public int Count { get; set; } = 0;





        public CustomList()
        {
            arr = new T[0];
        }
        public CustomList(int length)
        {
            arr=new T[length];
            Count = length;
        }
        public CustomList(params T[] nums)
        {
            arr = nums;
            Count = nums.Length;
        }

        public void Add(T value)
        {
            if (Capacity == 0)
            {
                Capacity = 4;
                Array.Resize(ref arr, Capacity);
            }
            if (Capacity == Count)
            {
                Array.Resize(ref arr,Length+Capacity);
                Capacity *= 2;

            }
            arr[Count] = value;
            Count++;
          


        }

        public void Remove(T item)
        {
            //{1230 0000}
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (found)
                {
                    arr[i - 1] = arr[i];
                }
                if (arr[i].Equals(item) && !found)
                {
                    arr[i] = default;
                    Count--;
                    found = true;
                    
                }
               
            }
            DecreaseCapacity();

        }

        public void RemoveRange(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Remove(values[i]);
            }
            
        }

        public void DecreaseCapacity()
        {
            //3   8-3 5>4

            int num = Capacity - Count;
            int half=Capacity/2;
             if (num > half)
            {
                T[] newArr = new T[arr.Length - half];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
                Capacity /= 2;
            }

        }
    }
}
