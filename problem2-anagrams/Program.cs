using System;
using System.Collections.Generic;

namespace problem2_anagrams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            string s = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            string[] splitList = s.Split(',');
            string star = "star";

            foreach (string s2 in splitList)
            {
                Console.WriteLine(s2);
                if (s2.Length > star.Length || s2.Length < star.Length)
                {
                    Console.WriteLine("{0} is not an anagram", s2);
                    continue;
                }
                Dictionary<char, int> dict = new Dictionary<char, int>();
                foreach (char x in s2)
                {
                    dict.Add(x, 0);
                }
                foreach (char x in s2)
                {
                    dict[x] += 1;
                }
                Boolean l = true;
                foreach (char letter in star)
                {
                    if (dict.ContainsKey(letter) && dict[letter] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        l = false;
                        Console.WriteLine("{0} is not an anagram ", s2); 
                        break;
                    }
                }
                if (l)
                {
                    Console.WriteLine("{0} is an anagram ", s2);
                }
            }
            Console.ReadLine();
        }
    }
}