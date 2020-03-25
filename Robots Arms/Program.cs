using System;
using System.Collections.Generic;
using System.Linq;

namespace Robots_Arms
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Job> jobs = new List<Job>();
            String input;
            String[] splitted;
            int X, L;
            for(int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                splitted = input.Split(' ');
                X = int.Parse(splitted[0]);
                L = int.Parse(splitted[1]);
                jobs.Add(new Job(Math.Max(0, X - L), X + L));
            }
            jobs.Sort((a, b) => a.t - b.t);
            int endTime = 0;
            int count=0;
            for(int i = 0; i < N; i++)
            {
                if (jobs[i].s >= endTime)
                {
                    count++;
                    endTime = jobs[i].t;
                }
            }
            Console.WriteLine(count);
        }
    }
    class Job
    {
        public int s;
        public int t;
        public Job(int S,int T)
        {
            s = S;
            t = T;
        }
    }
}
