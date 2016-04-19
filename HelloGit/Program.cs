using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static int Pow(int n, int x)
        {
            int pow = n;

            for (int i = 0; i < x - 1; i++)
            {
                pow *= n;
            }

            return pow;
        }

        static int Fact(int n)
        {
            int res = 1;

            for (int i = 1; i < n + 1; i++)
            {
                res *= i;
            }

            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub");

            Console.WriteLine("2 в степени 3 = " + Pow(2, 3));

            Console.WriteLine("Факториал 5 = " + Fact(5));

            Console.WriteLine("x^2-2b+1 = "+QuadraticEq(1,-2,1));

            Console.ReadKey();
        }

        static int QuadraticEq(int a, int b, int c)
        {
            int d = Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                return -b / (2 * a);
            }

            return -1;
        }
    }
}
