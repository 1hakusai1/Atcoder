using System;

namespace SqrtInequality
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] splitted = input.Split(' ');
            long a = long.Parse(splitted[0]);
            long b = long.Parse(splitted[1]);
            long c = long.Parse(splitted[2]);

            double ab = Math.Sqrt(a) + Math.Sqrt(b);
            double cc = Math.Sqrt(c);
            if (ab < cc)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
