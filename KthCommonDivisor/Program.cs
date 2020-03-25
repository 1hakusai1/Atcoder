using System;
using System.Collections.Generic;

namespace KthCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] str = input.Split(" ");
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int X = int.Parse(str[2]);

            List<int> Common=new List<int>();
            for(int i = Math.Min(A, B); i > 0; i--)
            {
                if (A % i == 0 && B % i == 0)
                {
                    Common.Add(i);
                }
            }
            Console.WriteLine(Common[X - 1]);
        }
    }
}
