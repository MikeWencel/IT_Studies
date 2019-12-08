using System;

namespace CreatingArrayWithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp = Console.ReadLine();
            int n = int.Parse(odp);
            int[] tab = new int[n];
            int i = 0;
            while(i < n){
                Console.Write("Podaj element numer " + i + " ");
                string ans = Console.ReadLine();
                int a = int.Parse(ans);
                tab[i] = a;
                i++;
                
            }
            

                Array.Sort(tab);
                Array.Reverse(tab);
            foreach(int element in tab){
                        Console.WriteLine(element + ",");
                }
        }
    }
}
