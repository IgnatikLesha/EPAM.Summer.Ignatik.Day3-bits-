﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public static class JaggedArray
    {

        public delegate int ArrayComparer(int[] lhs, int[] rhs);
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

        public static void Sort(int[][] array, ArrayComparer comparer)
        {
            if (array == null || comparer == null)
                throw new ArgumentNullException();
            Sort(array, new Adapter(comparer));
        }

        private class Adapter : IComparer
        {

            private ArrayComparer comparer;

            public Adapter(ArrayComparer comparer)
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
