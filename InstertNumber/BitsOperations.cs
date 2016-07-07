using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstertNumber
{
    public static class BitsOperations
    {
        public static int NumberOfBits(int number)
        {
            return Convert.ToString(number, 2).Length;
        }


        public static int InsertNumber(int first, int second, int left, int right)
        {
            if (left < 0 ||  left > 31 || right > 31 || right < 0 || left > right)
                throw new ArgumentException("Incorrect position");
            int len = right - left;

            if (NumberOfBits(second) > len)
                second >>= NumberOfBits(second) - len;
            second <<= left;
            return first | second;
        }

    }
}
