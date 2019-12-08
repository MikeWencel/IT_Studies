using System;

namespace methods
{
    class Program
    {

        static void Powitanie(){
            Console.WriteLine("Witaj!");
        }

        static void Pozegnanie(){
            Console.WriteLine("Dowidzenia");
        }
        static void Main(string[] args)
        {
            Powitanie();
            Console.WriteLine("Hello World!");
            Pozegnanie();
            Pozegnanie();
        }
    }
}
