using System;

namespace conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123443455;
            long bigNum = num;

            Console.WriteLine(bigNum);

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;

            // type conversion

            string myString = myDouble.ToString();

            Console.WriteLine(myString + 13);

            int myInt;
            //explicit conversion
            //Casting

            myInt = (int) myDouble;

            System.Console.WriteLine(myInt);
        }
    }
}
