using System;

namespace OOP_Inheritacne_Polymorphism_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Building a = new Building("ul. Morska 23");
            Console.WriteLine("Adres budynku to: " + a.Adress);
            FlatBuilding aa = new FlatBuilding("ul. Morska 32",100);
            Console.WriteLine("Adres budynku: " + aa.Adress + " mieszkańcy: " + aa.Residents);
        }
    }
}
