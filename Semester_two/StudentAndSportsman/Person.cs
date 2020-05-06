using System;
using System.Collections.Generic;

namespace StudentAndSportsman
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string dateOfBirth;

        public Person(string firstName, string lastName, string dateOfBirth){
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public string FirstName{
        get{return FirstName;}
        set{FirstName = value;}
        }

        public string LastName{
        get{return lastName;}
        set{lastName = value;}
        }

        public string DateOfBirth{
        get{return dateOfBirth;}
        set{dateOfBirth = value;}
        }

        public virtual void information(){
            Console.Write("First name: " + firstName + "\nLast name: " +
                             lastName + "\nDate of birth " + dateOfBirth);
        }
        
    }
}