using System;

namespace LabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            // Console.WriteLine("Wywołanie samochodu: " + firstCar.Mark + "Samochód nr:" + firstCar.CarAmount);
            Car secondCar = new Car("Mercedes","E190",5,2000,5.5,"WGR 3133");
            Car thirdCar = new Car("Audi","A4",5,2500,8.5,"GDA 3232");
            // Console.WriteLine("Marka: " + secondCar.Mark);
            // Console.WriteLine("Model: " + secondCar.Model);
            // Console.WriteLine("Ilość wywołań: " + secondCar.CarAmount);
            // Console.WriteLine("Trip Price is: " + secondCar.tripCost(250,1.60));
            Car fourthCar = new Car("Dacia","Dokker",3,1600,10,"WE 3232");
            // Console.WriteLine("Trip Price is: " + fourthCar.tripCost(400,1.70));
            // Console.WriteLine("Ilość wywołań: " + secondCar.CarAmount);
            // fourthCar.information();
            // Car.amount();
            
            
            
            Garage g1 = new Garage();
            g1.Adress = "ul. Garażowa 1";
            g1.GarageCapacity = 1;

            Garage g2 = new Garage("ul. Garażowa 2",2); 

              

            g1.parkTheCar(secondCar);
            // g2.parkTheCar(thirdCar);
            
            // g2.garageInfo();
           
            // g1.parkTheCar(secondCar);
            // g1.parkTheCar(thirdCar);
            
            // Person first = new Person("Mike","Wencel","Reda",0);
            
           
            // first.addCar("GWE 1232");
            // first.addCar("GPU 1777");
            // first.addCar("WE 1777");
            
            // first.subCar("GPU 1777");

            // first.addCar("GD 1777");
            
            

            // first.info();
            
            // UWAGA!! JEŚLI TRAFISZ NA MÓJ KOD, TO PRZEPRASZAM Z GÓRY, MAM NADZIEJĘ, ŻE ZROZUMIESZ DOŚĆ SZYBKO ;-)
           
           

            


        }
    }
}

