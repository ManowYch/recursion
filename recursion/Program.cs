using System;
using System.Collections.Generic;
using System.Text;

namespace recursion
{
    class Program
    {   static void Foo (ref int[] array, int index) 
        {
            Console.WriteLine(array[index]);
            index++;
            if (index <= (array.Length-1))
            {
                Foo(ref array, index);
            }
            else
            {
                Console.ReadKey();
            }
        }

        static void ElementsSum(ref int[] array, int index, int sum)
        {
            if (index <= (array.Length-1))
            {
                sum += array[index];
                index++;
                ElementsSum(ref array, index, sum);
            }
            else
            {
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 4, 3, 1, 5, 3, 2 };
            Foo(ref myArray, 0);
            ElementsSum(ref myArray, 0, 0);

        }
    }
}
