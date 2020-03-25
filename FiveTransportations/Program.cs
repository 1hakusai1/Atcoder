using System;
using System.Linq;

namespace FiveTransportations
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long D = long.Parse(Console.ReadLine());
            long E = long.Parse(Console.ReadLine());

            long[] movements = new long[] { A, B, C, D, E };
            long min = movements.Min();
            double calc = (double)N / min;
            long maxMovement = 4+(long)Math.Ceiling(calc);
            Console.WriteLine(maxMovement);
        }
    }
}
