using System;

namespace IntervalRunning
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] splitted = input.Split(' ');
            long[] T = new long[] { long.Parse(splitted[0]), long.Parse(splitted[1]) };
            input = Console.ReadLine();
            splitted = input.Split(' ');
            long[] A = new long[] { long.Parse(splitted[0]), long.Parse(splitted[1]) };
            input = Console.ReadLine();
            splitted = input.Split(' ');
            long[] B = new long[] { long.Parse(splitted[0]), long.Parse(splitted[1]) };

            long[] takahashi = new long[] { T[0] * A[0], T[1] * A[1] };
            long[] aoki = new long[] { T[0] * B[0], T[1] * B[1] };
            if (takahashi[0] + takahashi[1] == aoki[0] + aoki[1])
            {
                Console.WriteLine("infinity");
            }

        }
    }
}
