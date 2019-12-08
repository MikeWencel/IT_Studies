using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = {3,6,9,7,12,34,3,2,4,1};
            int temp = tablica[2];
            tablica[2] = tablica[8];
            tablica[8] = temp;
            foreach(int wartosc in tablica){
                Console.Write(wartosc + " ");
            }
            Console.WriteLine("");
        }
    }
}
