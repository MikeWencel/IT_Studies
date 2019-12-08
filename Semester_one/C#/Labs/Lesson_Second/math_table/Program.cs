using System;

namespace math_table
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int i = 0;i < 10;i++){
            for (int j = 0;j < 10;j++){
                Console.Write("{0}\t", (i + 1) * (j + 1));
            }Console.WriteLine();    
                }
            }
        }
    }

