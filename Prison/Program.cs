using System;
using System.Linq;

namespace Prison
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int N = int.Parse(spl[0]);
            int M = int.Parse(spl[1]);
            int[] L = new int[M];
            int[] R = new int[M];
            for(int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                spl = input.Split(" ");
                L[i] = int.Parse(spl[0]);
                R[i] = int.Parse(spl[1]);
            }

            int cardRange = R.Min() - L.Max()+1;
            int result = Math.Max(cardRange, 0);
            Console.WriteLine(result);
        }
    }
}
