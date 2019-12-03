using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceWielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[,] wspolrzedne = new string[15, 7];
            for (x = 0; x < 15; x++)
                for (y = 0; y < 7; y++)
                    wspolrzedne[x, y] = " nic ";

            wspolrzedne[10, 4] = "skarb";

            for (y = 0; y < 7; y++)
            {
                for (x = 0; x < 15; x++)
                    Console.Write(wspolrzedne[x, y] + " ");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}