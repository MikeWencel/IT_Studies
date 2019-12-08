using System;

namespace exceptTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj wiek: ");
            String odp = Console.ReadLine();

            try{
                int wiek = int.Parse(odp);
                Console.WriteLine("podano: " + wiek);
            }
            catch (System.FormatException ex){
                Console.WriteLine("Podane nieprawidłowe dane");
            }
        }
    }
}
