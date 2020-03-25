using System;

namespace _100to105
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            if (X / 100 >= CalcMin(X))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        static int CalcMin(int price)
        {
            int shimo2 = price % 100;
            int min = 0;
            for (int i = 5; i > 0; i--)
            {
                min += shimo2 / i;
                shimo2 = shimo2 % i;
            }
            return min;
        }
    }
}
