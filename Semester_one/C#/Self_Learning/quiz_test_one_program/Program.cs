using System;

namespace quiz_test_one_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string numberAsString;
            int number;
            int average;
            for(int i =0;i < 3;i++){
            numberAsString = Console.ReadLine();
            number = int.Parse(numberAsString);
            sum = sum + number;
            average = sum/3;
            if(i == 2){
                Console.WriteLine(average);
            }
            }
            
            
        }
    }
}
