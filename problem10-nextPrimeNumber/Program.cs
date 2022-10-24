using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem10_nextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original number is: " + n);
            Console.WriteLine("Next prime number is: " + prime(n));
            Console.ReadLine();
        }

        static int prime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { n++; i = 2; }
            }
            return n;
        }
    }
}
