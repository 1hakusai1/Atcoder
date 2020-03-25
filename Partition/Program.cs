using System;

namespace Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] str = input.Split(" ");
            int N = int.Parse(str[0]);
            int M = int.Parse(str[1]);

            for(int i = N; i <= M; i++)
            {
                if (M % i == 0)
                {
                    Console.WriteLine(M / i);
                    break;
                }
            }
        }
    }
}
