using System;
using System.Collections.Generic;
using System.Linq;

namespace Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int N = int.Parse(input);
            input = Console.ReadLine();
            String[] str = input.Split(" ");
            int[] H = new int[N];
            for(int i = 0; i < N; i++)
            {
                H[i] = int.Parse(str[i]);
            }

            List<int> move = new List<int>();
            int count = 0;
            for(int i = 0; i < N-1; i++)
            {
                if (H[i] >= H[i + 1])
                {
                    count++;
                }
                else
                {
                    move.Add(count);
                    count = 0;
                }
                if (i == N - 2)
                {
                    move.Add(count);
                }
            }
            int max = move.Max();
            Console.WriteLine(max);
        }
    }
}
