using System;

class Garage {
    private String adress;
    private int garageCapacity;

    private int carAmount = 0;

    private Car[] cars;

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
            carAmount = 0;
            cars = null;
    }

    public Garage (String adress,int garageCapacity){
        this.adress = adress;
        this.garageCapacity = garageCapacity;
        Car [] cars = new Car[garageCapacity];
    }

    public void parkTheCar(Car cars){


        if(garageCapacity < carAmount + 1){
        Console.WriteLine("There is no space!!!");
        }else {
        // Trochę miesza mi się Java i szukam sposobu w jaki sposób porównać tablicę do zmienne ? 
        // Szukam najprostszego rozwiązania, pierwsze co pomyślałem, żeby utworzyć pętle lub użyć metody,
        // która sprawdzi mi długość tablicy i wrzuciu to jako integer, a później ten integer, porównam do inta 
        }
    }

    

}