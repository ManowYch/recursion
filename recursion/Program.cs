using System;
using System.Collections.Generic;
using System.Text;

namespace recursion
{
    // Task: Implement array output using recursion.
    // Find the sum of array elements using recursion.
    // Find the sum of the digits of a number using recursion. (561 = 12)
    class Program
    { 
        static void Main(string[] args)
        {
            int[] myArray = { 4, 3, 1, 5, 3, 2 };
            Foo(ref myArray, 0);
            ElementsSum(ref myArray, 0, 0);
            NumbersSum(8543524, 0);
        }
    }
}
