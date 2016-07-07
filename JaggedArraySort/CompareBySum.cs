using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class CompareBySum: IComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            if (a.Sum() == int.MaxValue || b.Sum() == int.MaxValue)
                throw new OverflowException();

            if (a.Sum() > b.Sum())
                return 1;
            else if (a.Sum() < b.Sum())
                return -1;
            else
                return 0;
        }
    }
}
