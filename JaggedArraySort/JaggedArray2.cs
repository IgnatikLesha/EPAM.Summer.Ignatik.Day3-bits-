using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    class JaggedArray2
    {
        public delegate int ArrayComparer(int[] lhs, int[] rhs);
        public static void Sort(int[][] array, IComparer comparer)
        {
            ArrayComparer newcomparer = comparer.Compare;
            Sort(array, newcomparer);
        }

        public static void Sort(int[][] array, ArrayComparer comparer)
        {
            if (array == null || comparer == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(array[i], array[j]);
                    }
                }
            }
        }

        private class Adapter : IComparer
        {

            private JaggedArray.ArrayComparer comparer;

            public Adapter(JaggedArray.ArrayComparer comparer)
            {
                this.comparer = comparer;
            }

            public int Compare(int[] arr1, int[] arr2)
            {
                return comparer(arr1, arr2);
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
}
