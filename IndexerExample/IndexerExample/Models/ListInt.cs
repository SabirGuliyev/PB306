using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample.Models
{
    internal class ListInt
    {
        private int[] arr;


        public int this[int index]
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







        public ListInt()
        {
            arr = new int[0];
        }
        public ListInt(int length)
        {
            arr=new int[length];
        }
        public ListInt(params int[] nums)
        {
            arr = nums;
        }

        public void Add(int value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = value;
        }
    }
}
