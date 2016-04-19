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

            for (int i = 0; i < x-1; i++)
            {
                pow *= n;
            }

            return pow;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub");

            Console.WriteLine(Pow(2,3));

            Console.ReadKey();
        }
    }
}
