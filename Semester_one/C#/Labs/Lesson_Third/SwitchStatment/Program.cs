using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchGraFabularna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Znajdujejsz się przed wejściem do zamku w lesie." +
                "Zamek otoczony jest fosą i porośnięty bluszczem. Co robisz?");
            Console.WriteLine("W - Wchodzisz na dziedziniec zamku");
            Console.WriteLine("L - wchodzisz do lasu");
            Console.WriteLine("F - nurkujesz w fosie");
            Console.WriteLine("B - wspinasz się po bluszczu na wieżę zamkową");
            string odp = Console.ReadLine();

            switch (odp)
            {
                case "W":
                    Console.WriteLine("Atakuje Cię straż zamkowa i zamyka w lochu!");
                    break;
                case "L":
                    Console.WriteLine("Atakuje Cię dziki dzik! Uciekasz.");
                    break;
                case "F":
                    Console.WriteLine("Nie umiesz pływać. Topisz się");
                    break;
                case "B":
                    Console.WriteLine("Znajdujesz dawno zapomniany skarb. Gratulacje!");
                    break;
                default:
                    Console.WriteLine("Błędne polecenie!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
