﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public interface IComparer
    {
        int Compare(int[] a, int[] b);
    }
}
