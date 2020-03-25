using System;

namespace Count_Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] splitted = input.Split(' ');
            long N = long.Parse(splitted[0]);
            long A = long.Parse(splitted[1]);
            long B = long.Parse(splitted[2]);

            long answer = ((N / (A + B)) * A) + Math.Min((N % (A + B)),A);
            Console.WriteLine(answer);
        }
    }
}
