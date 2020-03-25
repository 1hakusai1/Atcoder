using System;

namespace ID
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] splitted = input.Split(' ');
            int N = int.Parse(splitted[0]);
            int M = int.Parse(splitted[1]);



        }
    }
    class City
    {
        int Rank;
        int P;
        int Y;
        String number;
        public City(int rank,int p,int y)
        {
            Rank = rank;
            P = p;
            Y = y;
        }
    }
}
