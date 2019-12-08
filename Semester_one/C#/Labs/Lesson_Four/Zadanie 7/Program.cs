using System;

namespace Zadanie_7
{
    class Program
    {   

        static int Obwod(int a){
            int sum = 4 * a;
            return sum;
        }

        static int Obwod(int a, int b){
            int sum = 2*a + 2*b;
            return sum;
        }
        static int Obwod(int a, int b, int c){
            int sum = a + b + c;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Obwód kwadratu: " + Obwod(2));
            Console.WriteLine("Obwód prostokątu " + Obwod(2,4));
            Console.WriteLine("Obwód Trójkąta " + Obwod(2,4,7));
        }
    }
}
