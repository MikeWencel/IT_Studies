using System;

public class Person 
{
private string firstName;
private string lastName;
private string adress;
private int cars = 0;

private string[] carsTable = new string [3];



public Person(){
    firstName = "Unknown";
    lastName = "Unknown";
    adress = "Unknown";
    cars = 0;
    carsTable = new string[]{"WE 22323"};
}

public Person(string firstName, string lastName, string adress, int cars){
    this.firstName = firstName;
    this.lastName = lastName;
    this.adress = adress;
    this.cars = cars;
}



public string FirstName
{
get{return FirstName;}
set{FirstName = value;}
}

public string LastName{
get{return lastName;}
set{lastName = value;}
}

public string Adress{
get{return adress;}
set{adress = value;}
}

public int Cars{
get{return cars;}
set{cars = value;}
}

public string[] CarsTable{
get{return carsTable;}
set{carsTable = value;}
}


public void addCar(string plateNumber){
    if(cars >= 3){
        Console.WriteLine("You can't afford that many cars");
    }else {
        this.carsTable[this.cars] = plateNumber;
        this.cars = cars + 1;
        }
    }

public void subCar(string plateNumber){
    string []temp = new string [3];
    int j = 0;
    for(int i = 0;i < this.carsTable.Length;i++){
        
        if(plateNumber != carsTable[i]){
            temp[j] = carsTable[i];
            j++;
        }
        Console.WriteLine("Temp table[" + j + "]=" + temp[j] + " CarsTable[" + i + "]" + carsTable[i]);
        
        
    }
    this.cars = cars - 1;
    this.carsTable = temp;
    }    
public void info(){
    Console.WriteLine(firstName);
    Console.WriteLine(lastName);
    Console.WriteLine(adress);
    Console.WriteLine(cars);
    foreach(string item in carsTable){
            Console.WriteLine(item);
        }
    
}    
        
        
    }




