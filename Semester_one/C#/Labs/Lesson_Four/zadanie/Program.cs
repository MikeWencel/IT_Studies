﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rysowanie
{
    class Program
    {
        static void RysujTrojkat()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        static void RysujKwadrat(){
            for(int i = 1; i <= 5;i++){
                for(int j = 1; j <= 5;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {   
            Console.Write("Ile figur ?");
            string odp1 = Console.ReadLine();
            int ile = int.Parse(odp1);
            for(int i = 0;i < ile;i++){
            Console.WriteLine("Kwadrat - K, Trójkąt - T");
            string odp = Console.ReadLine();
            
            
            switch (odp)
            {
                case "K":
                    RysujKwadrat();
                    break;
                case "T":
                    RysujTrojkat();
                    break;
                default:
                    Console.WriteLine("Błędne polecenie!");
                    break;
            }
            
        }
        }
    }
}