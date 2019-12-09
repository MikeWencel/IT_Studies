using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // int y = 10;
            // int v = ++y;
            // System.Console.WriteLine("v={0}, y={1}",v,y);

            double a = 10;
            Console.WriteLine(a+10/3);

            double b = 10;
            Console.WriteLine((b+10)/3);

            // string c = Console.ReadLine();

            
            
                Console.WriteLine("Podaj liczbę");
                string odp = Console.ReadLine();
                Console.WriteLine("Podaj liczbę");
                string odp2 = Console.ReadLine();
                Console.WriteLine("Podaj liczbę");
                string odp3 = Console.ReadLine();
            
                int first = Int32.Parse(odp);
                int second = Int32.Parse(odp2);
                int third = Int32.Parse(odp3);

                double sum = (first + second + third)/3;
                Console.WriteLine(sum);

                int x = 11, y = 12;
                int z = x++;
                Console.WriteLine("z={0}, x={1}", z,x);
        }
    }
}
