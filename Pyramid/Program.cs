using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] x = new int[N];
            int[] y = new int[N];
            int[] h = new int[N];
            String input;
            String[] str;
            for(int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                str = input.Split(" ");
                x[i] = int.Parse(str[0]);
                y[i] = int.Parse(str[1]);
                h[i] = int.Parse(str[2]);
            }

            for(int H = 0; H <= 1000000000; H++)
            {
                for(int Cx = 0; Cx <= 100; Cx++)
                {
                    for(int Cy = 0; Cy <= 100; Cy++)
                    {
                        if (IsColect(H, Cx, Cy, x, y, h))
                        {
                            Console.WriteLine("{0} {1} {2}", Cx, Cy, H);

                        }
                    }
                }
            }
        }
        static int CalcHeight(int H,int Cx,int Cy,int x,int y)
        {
            int h = Math.Max(0, H - Math.Abs(x - Cx) - Math.Abs(y - Cy));
            return h;
        }
        static bool IsColect(int H, int Cx, int Cy, int[] x,int[] y, int[] h)
        {
            int N = x.Length;
            for(int i = 0; i < N; i++)
            {
                if (CalcHeight(H, Cx, Cy, x[i], y[i]) != h[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
