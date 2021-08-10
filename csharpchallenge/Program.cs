using System;

namespace csharpchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int m = 2;
            int n = 5;

            Console.WriteLine((Math.Pow(n, b + 1) - Math.Pow(m, b + 1)));
        }
    }
}
