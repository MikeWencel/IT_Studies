using System;
namespace StudentAndSportsman
{
    public class SoccerPlayer : Person
    {
        private string position;
        private string club;
        private int numberOfGoals = 0;


        public SoccerPlayer(string firstName, string lastName, string dateOfBirth,string position, string club):
        base(firstName, lastName, dateOfBirth){
            this.position = position;
            this.club = club;
            this.numberOfGoals = 0;
        }
    }
}