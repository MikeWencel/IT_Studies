using System;

namespace OOP_Inheritacne_Polymorphism_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Building a = new Building("ul. Morska 23");
            Console.WriteLine("Adres budynku to: " + a.Adress);
            FlatBuilding building_b = new FlatBuilding("ul. Morska 32",100);
            Console.WriteLine("Budynek przy ulicy: " + building_b.Adress + " liczba mieszkańców: " + building_b.Residents);
        }
    }
}
