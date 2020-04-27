using System;

class Garage {
    private String adress;
    private int garageCapacity;




    private Car[] cars;

    private int num = 0;

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
        int num = cars.Length;
        
    }

    public void parkTheCar(Car cars){
        num = num + 1;
        if(num > garageCapacity){
            Console.WriteLine("You can't park here!");
            num = garageCapacity;
        }else {
            Console.WriteLine("You can park here!!");
        }
    }

    

}