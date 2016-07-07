using System;
using JaggedArraySort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JASort
{
    [TestClass]
    public class JaggedArraySortTests
    {
        [TestMethod]
        public void SortArray_PositiveArrayAndCompareBySum_SortedArray()
        {
            CompareBySum comparer = new CompareBySum();
           
            int[][] jagArr = new int[3][];
            jagArr[0] = new int[] { 1, 2, 3 };
            jagArr[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            jagArr[2] = new int[] { 1, 2, 3, 4 };

            int[][] resultArray = new int[3][];
            resultArray[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            resultArray[1] = new int[] { 1, 2, 3, 4 };
            resultArray[2] = new int[] { 1, 2, 3 };

            JaggedArray.Sort(jagArr, comparer);

            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortArray_ArrayAndNull_ArgumentNullException()
        {
            
            int[][] arr = new int[3][];
            arr[0] = new int[] { 6, 3, 2 };
            arr[1] = new int[] { 3, 5, 2, 0, 6, 1 };


            JaggedArray.Sort(arr, (IComparer)null);
        }
    }
}
