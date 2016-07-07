using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public static class JaggedArray
    {

        
        public static void Sort(int[][] array, IComparer comparer)
        {
            if (array == null || comparer == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) < 0)
                    {
                        Swap(array[i], array[j]);
                    }
                }
            }
        }


        private static void Swap(int[] a, int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }

    }
}
