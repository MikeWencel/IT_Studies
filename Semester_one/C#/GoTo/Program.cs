using System;

namespace GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp = "";

            Console.WriteLine("Witamy w Kawiarni!");
            Console.WriteLine("Co chcesz zrobić ?");
            Console.WriteLine("1 - Kawa");
            Console.WriteLine("2 - Kawa i ciastko");
            Console.WriteLine("3 - Kawa, ciastko i kanapka");
            odp = Console.ReadLine();
            int n = int.Parse(odp);
            int koszt = 0;

            switch(n){
                case 1:
                Console.WriteLine("Podaję kawę!");
                koszt = koszt + 15;
                break;
                case 2:
                Console.WriteLine("Podaję ciastko");
                koszt = koszt + 8;
                goto case 1;
                case 3:
                Console.WriteLine("Podaję kanapkę!");
                koszt = koszt + 10;
                goto case 2;
                default:
                Console.WriteLine("błedne polecenie");
                break;
            
            }
            Console.WriteLine("Całkowity koszt " + koszt);
        }
    }
}
