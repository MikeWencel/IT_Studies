using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   
            var code = new MyClass();
            Console.WriteLine($"HelloWorld {code.ReturnMessage()}");
        }
    }
}
