using System;
using System.Collections.Generic;

namespace StudentAndSportsman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Student one = new Student("Mike","Wencel","20.09.1987",2020,2,45666);
            Person two = new Person("Max","Schwarzer","13.12.1979");
            two.information();
            one.information();
        }
    }
}
