using System;

namespace zadanieSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your first number");
            string odp1 = Console.ReadLine();

            Console.Write("Write your second number");
            string odp2 = Console.ReadLine();

            try{
                int a = int.Parse(odp1);
                int b = int.Parse(odp2);
               
            catch (System.FormatException ex){
            }
        }
    }
}
