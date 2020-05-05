using System;

namespace OOP_Inheritacne_Polymorphism_Collections
{
    public class Building
    {
        protected string adress = null;

        public Building(string adress_){
            adress = adress_;
        }

        public string Adress{
        get{return adress;
        }
        }
        public void information(){
            Console.WriteLine(adress);
        }
    }
}