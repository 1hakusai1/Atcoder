using System;

namespace November30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M=new int[2];
            for (int i = 0; i < 2; i++)
            {
                String input = Console.ReadLine();
                String[] splitted = input.Split(' ');
                M[i] = int.Parse(splitted[0]);
            }
            if (M[0] == M[1])
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
