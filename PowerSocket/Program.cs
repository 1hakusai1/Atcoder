using System;

namespace PowerSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] str = input.Split(" ");
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);

            int C;
            if ((B - 1) % (A - 1) == 0)
            {
                C = (B - 1) / (A - 1);
            }
            else
            {
                C = 1 + ((B - 1) / (A - 1));
            }
            Console.WriteLine(C);
        }
    }
}
