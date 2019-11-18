using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tablica = {3,6,9,7,12,34,3,2,4,1};
            Array.Sort(tablica);
            foreach(int element in tablica){
                Console.Write(element + ", ");
            }
            Console.WriteLine("");
        }   
        // Nauczyć się wszystkich metod sortowania
    }
}
