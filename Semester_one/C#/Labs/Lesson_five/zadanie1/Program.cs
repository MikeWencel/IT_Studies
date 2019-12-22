using System;

namespace zadanie1
{
    class Program
    {
        struct samochod {
            public string marka;
            public string model;
            public int rokProdukcji;
            public int przebieg;

        }
        static void Main(string[] args)
        {
            samochod a;
                a.marka = "Opel";
                a.model = "Astra";
                a.rokProdukcji = 2015;
                a.przebieg = 30000;

            samochod b;
                b.marka = "Ford";
                b.model = "Focus";
                b.rokProdukcji = 2013;
                b.przebieg = 50000;    

            Console.WriteLine(a.przebieg + b.przebieg);

            if (b.rokProdukcji < a.rokProdukcji){
                Console.WriteLine(b.marka + ", " + b.model + ", " + b.rokProdukcji);
            } else {
                Console.WriteLine(a.marka + ", " + a.marka +", "+ b.rokProdukcji);
            }   
                
            
        }
    }
}
