using System;

namespace OOP_Inheritacne_Polymorphism_Collections
{
    public class FlatBuilding: Building
    {
        private int residents = 0;

        public FlatBuilding(string adress_,int residents_):
        base(adress_)
        {
            residents = residents_;
        }

        public int Residents{
        get{return residents;}
        
        }

        

        
    }
}