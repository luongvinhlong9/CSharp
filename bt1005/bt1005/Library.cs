using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1005
{
    internal class Library
    {
        public int findMax(int[] array)
        {
            int max=array[0];
            for(int i=1; i<array.Length; i++)
            {
                if(max<array[i])
                    max=array[i];
            }
            return max;
        }

        public int findMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }

        public void findMaxApear(int[] array)
        {
            int[] tempArray;
            int MaxApear = array[0], Apear=0;
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; i <= tempArray.Length; j++)
                {
                    if (array[i] == tempArray[j])
                        continue;
                    else
                    {
//check
                        if () 
                    }
                }
            }


        }   
    }
}
