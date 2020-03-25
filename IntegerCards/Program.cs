using System;
using System.Linq;
using System.Collections.Generic;

namespace IntegerCards
{
    class BandC
    {
        public int B;
        public int C;
        public BandC(int b, int c)
        {
            B = b;
            C = c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] spl = input.Split(" ");
            int N = int.Parse(spl[0]);
            int M = int.Parse(spl[1]);
            int[] A = new int[N];
            input = Console.ReadLine();
            spl = input.Split(" ");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(spl[i]);
            }
            List<BandC> BCs = new List<BandC>();
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                spl = input.Split(" ");
                BCs.Add(new BandC(int.Parse(spl[0]), int.Parse(spl[1])));
            }

            Array.Sort(A);
            BCs.Sort((a, b) => b.C - a.C);
            int nowA = 0;
            int nowBC = 0;
            while (A[nowA] < BCs[nowBC].C)
            {
                A[nowA] = BCs[nowBC].C;
                nowA++;
                BCs[nowBC].B -= 1;
                if (BCs[nowBC].B == 0)
                {
                    nowBC++;
                }
                if (nowA >= N || nowBC >= M)
                {
                    break;
                }
            }

            long result = 0;
            foreach (int a in A)
            {
                result += (long)a;
            }
            Console.WriteLine(result);

        }
    }
}
