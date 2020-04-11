using System;

namespace LabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            samochod firstCar = new samochod();
             Console.WriteLine("Wywołanie samochodu: " + firstCar.Mark + "Samochód nr:" + firstCar.CarAmount);
            samochod secondCar = new samochod("Mercedes","E190",5,2000,5.5);
            samochod thirdCar = new samochod("Audi","A4",5,2500,8.5);
            Console.WriteLine("Marka: " + secondCar.Mark);
            Console.WriteLine("Model: " + secondCar.Model);
            Console.WriteLine("Ilość wywołań: " + secondCar.CarAmount);
            Console.WriteLine("Trip Price is: " + secondCar.tripCost(250,1.60));
            samochod fourthCar = new samochod("Dacia","Dokker",3,1600,10);
            Console.WriteLine("Trip Price is: " + fourthCar.tripCost(400,1.70));
            Console.WriteLine("Ilość wywołań: " + secondCar.CarAmount);
            fourthCar.information();
            samochod.amount();
            

            
           


        
        }
    }
}
