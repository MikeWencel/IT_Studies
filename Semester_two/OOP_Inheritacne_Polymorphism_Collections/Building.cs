using System;

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
        public virtual void information(){
            Console.WriteLine(adress);
        }

    }
