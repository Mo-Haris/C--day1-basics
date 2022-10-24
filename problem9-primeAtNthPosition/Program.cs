using System;

namespace problem9_primeAtNthPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
                67, 71, 73, 79, 83, 89, 97};

            Console.Write("Input  a position ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n<array.Length) 
            {
                int element = array[n - 1];
                Console.WriteLine(element);
            }
            else
            {
                Console.WriteLine("Enter a number upto " + array.Length);
            }


        }
    }
}
