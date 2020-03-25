using System;
using System.Collections.Generic;
using System.Linq;

namespace GCDonBlackboad
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(spl[i]);
            }

            List<int> divisors1 = new List<int>();
            for (int i = 1; i <= Math.Sqrt(A[0]); i++)
            {
                if (A[0] % i == 0)
                {
                    divisors1.Add(i);
                    divisors1.Add(A[0] / i);
                }
            }
            divisors1.Sort();
            int count;
            int result1 = 1;
            for (int i = divisors1.Count - 1; i >= 1; i--)
            {
                count = 0;
                for (int m = 1; m < N; m++)
                {
                    if (A[m] % divisors1[i] != 0)
                    {
                        count++;
                    }
                }
                if (count <= 1)
                {
                    result1 = divisors1[i];
                    break;
                }
            }

            List<int> divisors2 = new List<int>();
            for (int i = 1; i <= Math.Sqrt(A[1]); i++)
            {
                if (A[1] % i == 0)
                {
                    divisors2.Add(i);
                    divisors2.Add(A[1] / i);
                }
            }
            divisors2.Sort();
            int result2 = 1;
            for (int i = divisors2.Count - 1; i >= 1; i--)
            {
                count = 0;
                for (int m = 2; m < N; m++)
                {
                    if (A[m] % divisors2[i] != 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    result2 = divisors2[i];
                    break;
                }
            }
            Console.WriteLine(Math.Max(result1, result2));
        }
    }
}
