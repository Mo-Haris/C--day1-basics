using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1_longestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = {1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0};

            int max_count = 0;
            int count = 0;

            for (int i = 0; i <= x.Length; i++)
            {
                Console.WriteLine(i);
                if (x == ",") {
                    continue;
                }
            }
        }
    }
}

//def ans(code):
   // max_count = 0
   // count = 0
   // for x in range(0, len(code)):
    //    if code[x] == ",":
      //      continue
       // if code[x] == "0":
      //      count += 1
       //     if count > max_count:
       //         max_count = count
       // else:
       //     if count > max_count:
       //         max_count = count
       //     count = 0
   // return max_count