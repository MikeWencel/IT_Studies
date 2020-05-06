using System;
using System.Collections.Generic;

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
            building_b.information();
            a.information();
            List<Building> building_list = new List<Building>();
            Building c = new Building("ul. Morska 23B");
            Building d = new Building("ul. Morska 23C");
            Building e = new Building("ul. Morska 23D");
            Building g = new Building("ul. Moskiewska 23");
            building_list.Add(a);
            building_list.Add(d);
            building_list.Insert(0,c);
            building_list.Insert(0,g);

            int buildings = building_list.Count;
            Building f = building_list[1];
            
            foreach (var item in building_list)
            {
                Console.Write(item.Adress + ", ");
            }

            
            

        }
    }
}
