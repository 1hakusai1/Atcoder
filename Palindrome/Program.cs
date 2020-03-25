using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String S = Console.ReadLine();
            int count = 0;
            if (S.Length % 2 == 0)
            {
                for (int i = 0; i < S.Length/2; i++)
                {
                    if (S[i] != S[S.Length - 1 - i])
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < (S.Length+1) / 2; i++)
                {
                    if (S[i] != S[S.Length - 1 - i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("{0}", count);
        }
    }
}
