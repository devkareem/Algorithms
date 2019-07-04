using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation.BubbleSort
{
    public class BubbleSort
    {
        public int[] Sort(int[] intArray)
        {
            if (intArray == null) throw new ArgumentNullException("Int Array", "don't allow to you pass null value for this Method");
            int size = intArray.Length;
            int unSortedLength = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < unSortedLength; j++)
                {
                    if (intArray[j - 1] > intArray[j])
                    {
                        Swap(intArray, j - 1, j);
                    }
                }
                unSortedLength--;
            }
            return intArray;
        }

        private void Swap(int[] intArray, int v, int j)
        {
            int temp = intArray[v];
            intArray[v] = intArray[j];
            intArray[j] = temp;
        }
    }
}
