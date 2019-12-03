using System;

namespace Second_day
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int sum = 0;
        //    int n = 11; 
        //    for(int i = 1;i < 11;i++){
        //        sum = i * n;
        //        Console.WriteLine(i + " * " + n + " = " + sum);
        //    }

           string number = Console.ReadLine();
           int n = int.Parse(number);
           int sum = 0;
           for(int i = 1;i<= n;i++){
               sum = i + sum;
               
           }
           Console.WriteLine("suma " + n + " pierwszych liczb = " + sum);
        }
    }
}
