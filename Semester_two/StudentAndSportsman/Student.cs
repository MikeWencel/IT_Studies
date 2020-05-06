using System;
namespace StudentAndSportsman
{
    public class Student : Person
    {
        private int year;
        private int group;
        private int indeks;


        public Student(string firstName, string lastName, string dateOfBirth, int year, int group, int indeks):
            base(firstName,lastName,dateOfBirth){
                this.year = year;
                this.group = group;
                this.indeks = indeks;

            }

        public int Year{
        get{return year;}
        set{year = value;}
        }

        public int Group{
        get{return year;}
        set{group = value;}
        }

        public int Indeks{
        get{return indeks;}
        set{indeks = value;}
        }
        public override void information(){
            Console.Write("First name: " + firstName + "\nLast name: " +
                             lastName + "\nDate of birth " + dateOfBirth + "\nYear: " + Year + "\nGroup: " + Group
                              + "\nIndeks: " + Indeks);
        }    
        
    }
}