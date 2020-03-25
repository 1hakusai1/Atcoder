using System;
using System.Linq;

namespace FlippingSigns
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int[] A = new int[N];
            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(spl[i]);
            }

            long result=0;
            int countNegative = A.Count(n => n < 0);
            for(int i = 0; i < N; i++)
            {
                A[i] = Math.Abs(A[i]);
            }
            if (countNegative % 2 == 0)
            {
                foreach(int n in A)
                {
                    result += n;
                }
            }
            else
            {
                foreach(int n in A)
                {
                    result += n;
                }
                result -= 2 * A.Min();
            }
            Console.WriteLine(result);
        }
    }
}
