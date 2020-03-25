using System;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] splitted = input.Split(' ');
            int N = int.Parse(splitted[0]);
            int M = int.Parse(splitted[1]);
            int[] s = new int[M];
            int[] c = new int[M];
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine();
                splitted = input.Split(' ');
                s[i] = int.Parse(splitted[0]);
                c[i] = int.Parse(splitted[1]);
            }

            int answer = -1;
            for (int i = 0; i < 1000; i++)
            {
                if (((int)(Math.Log10(i))) + 1 != N)
                {
                    continue;
                }
                for (int j = 0; j < M; j++)
                {
                    if (i.ToString()[s[j]-1] != c[j])
                    {
                        break;
                    }
                    answer = i;
                }
                if (answer != -1)
                {
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
