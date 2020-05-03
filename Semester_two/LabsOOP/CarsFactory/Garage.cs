using System;
using System.Linq;

class Garage {
    private String adress;
    private int garageCapacity;

    private Car[] cars;
    

    private int carAmount = 0;

    public String Adress {
        get {
            return adress;
        }
        set {
            adress = value;
        }
    }
    public int GarageCapacity {
        get{
            return garageCapacity;
        }
        set {
            garageCapacity = value;
            cars = new Car[garageCapacity];
            
        }
    }

    public Garage (){
            adress = "unknown";
            garageCapacity = 0;
            cars = null;
    }

    public Garage (String adress,int garageCapacity){
        this.adress = adress;
        this.garageCapacity = garageCapacity;
        Car [] cars = new Car[garageCapacity];
        int carAmount = cars.Length;
        
    }

    public void parkTheCar(Car cars){
        
        this.carAmount = carAmount + 1;
        if(carAmount > garageCapacity){
            Console.WriteLine("You can't park here!");
            this.carAmount = carAmount - 1;
        }else {
            this.cars[carAmount -1] = cars;
            Console.WriteLine(cars.Mark + " parked");
            
        }
        
    }

    public void GarageInfo(){
        for(int i = 0;i < carAmount;i++){
            Car s = cars[i];
            // Console.WriteLine(i);
            Console.WriteLine("In garage, there is " + s.Mark);
        }
    }


        public Car parkout(){
            if(carAmount > 0){
        this.cars[carAmount-1] = null;
        this.carAmount = carAmount -1;
        Console.WriteLine("Car parked out!");
            }
        return this.cars[carAmount];

    }
    

}