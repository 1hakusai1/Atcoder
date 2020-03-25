using System;

namespace Alchemist
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] v = new int[N];
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            for(int i = 0; i <N; i++)
            {
                v[i] = int.Parse(spl[i]);
            }

            Array.Sort(v);
            double final = v[0];
            for(int i = 1; i < N; i++)
            {
                final = (final + v[i]) / 2;
            }
            Console.WriteLine(final);
        }
    }
}
