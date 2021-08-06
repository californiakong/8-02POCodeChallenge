using System;
using System.Collections.Generic;
using System.Linq;

namespace codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Minneapolis";
            string s2 = "Minnesota";
            int common = 0;
            List<int> commonSubSequence = new List<int>();

            for (int i = 0; i < s1.Length && i < s2.Length; i++) {
                if (s1[i] == s2[i]) {
                    common++;
                } else {
                    commonSubSequence.Add(common);
                    common = 0;
                }   
            }
            commonSubSequence.Add(common);
            Console.WriteLine(commonSubSequence.Max());
        }
    }
}
