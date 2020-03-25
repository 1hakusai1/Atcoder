using System;

namespace ModSum
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int N = int.Parse(input);

            int sum = N * (N - 1) * 1 / 2;
            Console.WriteLine(sum);
        }
    }
}
