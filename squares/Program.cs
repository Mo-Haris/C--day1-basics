using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            double Sqr = Math.Pow(Number, 3);
            Console.WriteLine("Square of {0} is: {1}", Number, Sqr);
            Console.ReadLine();
        }
    }
}
