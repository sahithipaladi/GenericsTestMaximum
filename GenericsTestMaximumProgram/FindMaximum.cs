﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Test_Maximum
{
    public class MaximumAmongThree<T> where T : IComparable
    {
        public T[] array;
        public MaximumAmongThree(T[] array)
        {
            this.array = array;
        }
        public T[] Sort()
        {
            Array.Sort(array);
            return array;
        }
        public T FindMaxValue()
        {
            T[] sorted = this.Sort();
            return sorted[sorted.Length - 1];
        }
    }
}