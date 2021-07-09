using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Among Three");
            int[] intArray = { 343, 782, 863, 734, 632 };
            float[] floatArray = { 19.2f, 54.4f, 9.32f, 45.5f, 8.78f };
            string[] stringArray = { "Apple", "Peach", "Banana", "Mango", "Orange" };

            MaximumAmongThree<int> max1 = new MaximumAmongThree<int>(intArray);
            MaximumAmongThree<float> max2 = new MaximumAmongThree<float>(floatArray);
            MaximumAmongThree<string> max3 = new MaximumAmongThree<string>(stringArray);

            Console.WriteLine("Maximum Integer Number : " + max1.FindMaxValue());
            Console.WriteLine("Maximum Float Number : " + max2.FindMaxValue());
            Console.WriteLine("Maximum String : " + max3.FindMaxValue());

        }
    }
}


