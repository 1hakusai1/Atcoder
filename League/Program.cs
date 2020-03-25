using System;
using System.Collections.Generic;
using System.Linq;

namespace League
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String input;
            String[] spl;
            Queue<int>[] players = new Queue<int>[N];
            Queue<int> forInput;
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                spl = input.Split(" ");
                forInput = new Queue<int>();
                for (int m = 0; m < N - 1; m++)
                {
                    forInput.Enqueue(int.Parse(spl[m]));
                }
                players[i] = forInput;
            }

            int count = 0;
            List<int> canBattle;
            while (players.Any(que => que.Count != 0))
            {
                canBattle = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    if (players[i].Count!=0)
                    {
                        if (players[players[i].Peek() - 1].Peek() - 1 == i)
                        {
                            canBattle.Add(i);
                        }
                    }
                }
                if (canBattle.Count == 0)
                {
                    count = -1;
                    break;
                }
                else
                {
                    count++;
                    foreach (int i in canBattle)
                    {
                        players[i].Dequeue();
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
