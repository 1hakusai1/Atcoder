using System;

namespace GotoSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(spl[i]);
            }

            int[] output = new int[N];
            for (int i = 0; i < N; i++)
            {
                output[A[i]-1] = i+1;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(output[i]);
                Console.Write(" ");
            }
        }
    }
}
