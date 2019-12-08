using System;

namespace Gigabyte
{
    class Program
    {

    static long Gigabajt(){
        long b = 1024 * 1024 * 1024;
        return b;

    }

    static int Suma(){
        int sum = 0;
        for(int i = 1;i<=100;i++){
        sum = i + sum;
        }
        return sum;
    }
        static void Main(string[] args)
        {   
            Console.WriteLine(Suma()*21);
            long bajty = 5 * Gigabajt();
            Console.WriteLine("5 gigabajtów to dokładnie: "+ bajty + " bajtów");
        }
    }
}
