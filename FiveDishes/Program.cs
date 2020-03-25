using System;

namespace FiveDishes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = new int[5];
            int[] timePlusWait = new int[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] = int.Parse(Console.ReadLine());
                if (time[i] % 10 != 0)
                {
                    timePlusWait[i] = time[i] + 10 - time[i] % 10;
                }
                else
                {
                    timePlusWait[i] = time[i];
                }
            }

            int mini = 1;
            for (int i = 1; i < 5; i++)
            {
                if (time[i] % 10 != 0 && time[mini] % 10 < time[i] % 10)
                {
                    mini = i;
                }
            }
            int sumTime=0;
            for(int i = 0; i < 5; i++)
            {
                sumTime += timePlusWait[i];
            }
            sumTime = sumTime - timePlusWait[mini] + time[mini];
            Console.WriteLine(sumTime);
        }
    }
}
