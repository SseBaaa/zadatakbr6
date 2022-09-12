using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broj = 3;
            double rezultat = 0;
            Console.WriteLine("Unesi clanove reda");
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                rezultat = rezultat + 1 / broj;
                broj = broj * 3;
            }

            Console.WriteLine(rezultat);
            Console.ReadKey();
        }
    }
}
