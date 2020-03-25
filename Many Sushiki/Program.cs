using System;
using System.Collections.Generic;

namespace Many_Sushiki
{
    class Program
    {
        static void Main(string[] args)
        {
            String S = Console.ReadLine();
            int n = S.Length-1;
            long answer=0;
            List<List<int>> insert = new List<List<int>>();
            for(int i = 0; i < (1 << n); i++)
            {
                List<int> plan = new List<int>();
                for(int j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        plan.Add(j);
                    }
                }
                insert.Add(plan);
            }
            for(int i = 0; i < insert.Count; i++)
            {
                if (insert[i].Count == 0)
                {
                    answer += long.Parse(S);
                }
                else
                {
                    int start = 0;
                    int end=0;
                    for(int j = 0; j < insert[i].Count; j++)
                    {
                        end = insert[i][j]+1;
                        answer += long.Parse(S.Substring(start, end - start));
                        start = end;
                    }
                    answer += long.Parse(S.Substring(end, S.Length - end));
                }
            }
            Console.WriteLine(answer);
        }
    }
}
