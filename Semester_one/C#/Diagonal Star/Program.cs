using System;

namespace Diagonal_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine();
            int n = int.Parse(numberOne);
            
        

            for(int i = 1;i <= n;i++){
                for(int j = 1; j <= i;j++){
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
