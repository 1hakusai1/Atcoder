using System;

namespace DiceandCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int N = int.Parse(spl[0]);
            int K = int.Parse(spl[1]);

            double probability = 0;
            double p ;
            int m;
            for(int i = 1; i <= N; i++)
            {
                m = i;
                p = 1/(double)N;
                while (m < K)
                {
                    m = m * 2;
                    p = p / 2.0;
                }
                probability += p;
            }
            Console.WriteLine(probability);
        }
    }
}
