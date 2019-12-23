using System;

namespace AllAboutStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kasia";
            string who = "wife";
            string myName = "Mike";
            string secondName = "Mike";

            
            Console.WriteLine("--------------");
            Console.WriteLine("To Upper");
            name.ToUpper();
            Console.WriteLine("--------------");
            Console.WriteLine("To Lower");
            myName.ToLower();
            Console.WriteLine("Equals() --> False");
            Console.WriteLine(who.Equals(name));
            Console.WriteLine("Equals() --> True");
            Console.WriteLine(myName.Equals(secondName));
            Console.WriteLine(name + " is my " + who);
            
        }
    }
}
