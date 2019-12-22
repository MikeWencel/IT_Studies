using System;

namespace rekurencja
{
    class Program
    {

        static int Fib(int n){
            if(n == 1 || n == 2){
                return 1;
            }
            else
             return (Fib(n-1) + Fib(n-2));
            
        }

        static int Potega(int n, int a){
            if (a == 0)
                return 1;
            else    
            return n * Potega(n, a -1);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(Fib(10));
            Console.WriteLine(Potega(2,10));
            
        }
    }
}
