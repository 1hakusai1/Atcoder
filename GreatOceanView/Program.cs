using System;

namespace GreatOceanView
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String input = Console.ReadLine();
            String[] str = input.Split(" ");
            int[] H = new int[N];
            for (int i = 0; i < N; i++)
            {
                H[i] = int.Parse(str[i]);
            }

            int count = 1;
            int maxHeight = H[0];
            for(int i = 1; i < N; i++)
            {
                if (H[i] >= maxHeight)
                {
                    count++;
                    maxHeight = H[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}
