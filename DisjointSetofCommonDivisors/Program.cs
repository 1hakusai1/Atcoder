using System;
using System.Collections.Generic;

namespace DisjointSetofCommonDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int A = int.Parse(spl[0]);
            int B = int.Parse(spl[1]);

            List<int> commonDivisors = new List<int>();
            for(int i = 1; i <= Math.Sqrt(A); i++)
            {
                if (A % i == 0)
                {
                    if (B % i == 0)
                    {
                        commonDivisors.Add(i);
                    }
                    if (B % (A / i) == 0)
                    {
                        commonDivisors.Add(A/i);
                    }
                }
            }
            commonDivisors.Sort();
            int maxCommonDivisor = commonDivisors[commonDivisors.Count - 1];
            int count = 1;
            while (maxCommonDivisor != 1)
            {
                for(int i = 1; i < commonDivisors.Count; i++)
                {
                    if (maxCommonDivisor % commonDivisors[i] == 0)
                    {
                        count++;
                    }
                    while (maxCommonDivisor % commonDivisors[i] == 0)
                    {
                        maxCommonDivisor = maxCommonDivisor / commonDivisors[i];
                    }
                }
            }
            Console.WriteLine(count);


            //foreach(int n in commonDivisors)
            //{
            //    Console.Write(n);
            //    Console.Write(" ");
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine(maxCommonDivisor);
        }
    }
}
