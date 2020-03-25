using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenRelation
{
    class Edge
    {
        public int u;
        public int v;
        public int w;
        public Edge(int U,int V,int W)
        {
            u = U;
            v = V;
            w = W;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String input;
            String[] spl;
            List<Edge> graph = new List<Edge>();
            for(int i = 0; i < N - 1; i++)
            {
                input = Console.ReadLine();
                spl = input.Split(" ");
                graph.Add(new Edge(int.Parse(spl[0]),int.Parse(spl[1]),int.Parse(spl[2])));
            }

            graph.Sort((a, b) => a.u - b.u);
            foreach(Edge e in graph)
            {
                Console.WriteLine(e.u);
            }

            bool[] result = new bool[N];
            for (int i = 0; i < N; i++)
            {
                result[i] = false;
            }


        }
    }
}
