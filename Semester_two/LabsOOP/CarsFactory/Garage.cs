using System;

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

    public void parkTheCar(Car Mark){
        
        this.carAmount = carAmount + 1;
        if(carAmount > garageCapacity){
            Console.WriteLine("You can't park here!");
        }else {
            this.cars[carAmount-1] = Mark;
            Console.WriteLine("Car Parked " + Mark);
            
        }
    }


        public Car parkout(){
        if(this.carAmount <= 0){
            Console.WriteLine("It's empty");
            return this.cars[0] = null;
        }else {
            this.cars[carAmount] = cars[carAmount-1];
            return this.cars[carAmount];
        }
    }


    


    

}