using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Test_Maximum
{
    public class MaximumAmongThree<T> where T : IComparable
    {
        public T[] inputArray;
        public MaximumAmongThree(T[] array)
        {
            this.inputArray = array;
        }
        public T[] SortArray()
        {
            Array.Sort(inputArray);
            return inputArray;
        }
        public T FindMaxValue()
        {
            T[] sorted = this.SortArray();
            return sorted[sorted.Length - 1];
        }
        public void PrintMax()
        {
            Console.WriteLine("Maximum Value is : " + this.FindMaxValue());
        }
    }
}
