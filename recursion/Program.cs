using System;
using System.Collections.Generic;
using System.Text;

namespace recursion
{
    // Task: Implement array output using recursion.
    // Find the sum of array elements using recursion.
    // Find the sum of the digits of a number using recursion. (561 = 12)
    class Program
    {   static void Foo(ref int[] array, int index = 0)
        {
            Console.WriteLine(array[index]);
            index++;
            if (index < array.Length)
            {
                Foo(ref array, index);
            }
            else
            {
                Console.ReadKey();
            }
        }

        static void ElementsSum(int[] array, int index = 0, int sum =0)
        {
            if (index < array.Length)
            {
                sum += array[index];
                ElementsSum(array, index + 1, sum);
            }
            else
            {
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }

        static void NumbersSum(int userNumber, int result = 0)
        {
            
            result += userNumber % 10;
            userNumber /= 10;

            if (userNumber >= 1)
            {
                NumbersSum(userNumber, result);
            }
            else
            {
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 4, 3, 1, 5, 3, 2 };
            Foo(ref myArray);
            ElementsSum(myArray);
            NumbersSum(345);
        }
    }
}
