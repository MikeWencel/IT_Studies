using System;

namespace LoopInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            int n = int.Parse(numberOne);
            int k = int.Parse(numberTwo);
        

            for(int i = 1;i <= k;i++){
                for(int j = 1; j <= n;j++){
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
