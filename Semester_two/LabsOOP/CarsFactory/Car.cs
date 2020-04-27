using System;
class Car{
    private string mark;
    private string model;
    private int doors;
    private int capacity;
    
    private double avgFuel;
    private static int carAmount = 0;

    private string plateNumber;
    
    public string PlateNumber{
    get{return plateNumber;}
    set{plateNumber = value;}
    }

    public string Model {
        get {
            return model;
        }
        set {
            model = value;
        }
    }

    public int Doors {
        get {
            return doors;
        }
        set {
            doors = value;
        }
    }

    public int Capacity { get {
        return Capacity;
    } 
    set {
        Capacity = value;
        } 
    }
    public string Mark {
        get {
            return mark;
        }
        set {
            mark = value;
        }
    }

    public double AvgFuel{
        get {
            return avgFuel;
            }
        set {
            avgFuel = value;
            }
    }

    public int CarAmount {
        get {
            return carAmount;
        }
        set {
            carAmount = value;
        }
    }

   

public Car (){
    model = "Unknown";
    mark = "Unknown";
    doors = 0;
    capacity = 0;
    avgFuel = 0.0;
    carAmount++;
    
    

}

public Car (string mark,string model,int doors, int capacity, double avgFuel,string plateNumber){
    this.model = model;
    this.mark = mark;
    this.doors = doors;
    this.capacity = capacity;
    this.avgFuel = avgFuel;
    
    carAmount++;
    

}

private double combustion(double length){
    return avgFuel * length/100.0;
    
    
}

public double tripCost(double length, double fuelPrice){
    return combustion(length) * fuelPrice;
}


public void information(){
    Console.WriteLine("Marka: "+ mark);
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Ilość drzwi: " + doors);
    Console.WriteLine("Pojemność silnika " + capacity);
    Console.WriteLine("Średnie spalanie " + avgFuel);
    Console.WriteLine("Numer rejestracyjny " + plateNumber);
   
    
}

public static void amount(){
    Console.WriteLine(carAmount);
}

}
