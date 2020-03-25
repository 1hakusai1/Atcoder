using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String S = Console.ReadLine();

            if (N % 2 != 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                if (isEcho(N, S))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }

        static bool isEcho(int n, string s)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[i + n / 2])
                {
                    return false;

                }
            }
            return true;
        }
    }
}
