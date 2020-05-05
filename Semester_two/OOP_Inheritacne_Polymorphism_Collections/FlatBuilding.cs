namespace OOP_Inheritacne_Polymorphism_Collections
{
    public class FlatBuilding: Building
    {
        private int residents = 0;

        public FlatBuilding(string adres_,int residents_):
        base(adres_)
        {
            residents = residents_;
        }

        public int Residents{
        get{return residents;}
        
        }
    }
}