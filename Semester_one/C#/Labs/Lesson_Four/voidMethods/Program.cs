using System;

namespace voidMethods
{
    class Program
    { 
        static void Wypisuj(int number, String word){
            for(int i = 1;i <= number;i++){
                Console.WriteLine(i +" " + word);
            }
        }

        static int Potega(int a, int b){
            int sum = 0;
            for(int i = 1;i <= b;i++){
                sum = (a * i) + sum;
            }return sum;
        }

        static void Main(string[] args)
        {
            // Wypisuj(5,"stop");
            Console.WriteLine(Potega(2,2));
            Console.WriteLine(Potega(2,3));
            Console.WriteLine(Potega(2,4));
        }
    }
}
