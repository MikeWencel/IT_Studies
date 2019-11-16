using System;

namespace First_Episode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // string przedmiot = "masło";
            // String przedmioty = "masłochleb";

            // Console.WriteLine(przedmiot);
            // Console.WriteLine(przedmioty);
            // int x = 4;
            // Console.WriteLine(x);
            // x = x + 1;
            // Console.WriteLine(x);
            // x = x * x;
            // Console.WriteLine(x);
            // x= x % 3;
            // Console.WriteLine(x);


        // int ileSztuk = 4;
        // double cenaZaSztuka = 3.51;
        // double sum = 0;
        // sum = ileSztuk * cenaZaSztuka;
        // Console.WriteLine("Wartość zakupu to " + sum);

        // double high = 2.5;
        // double width = 8;
        // double length = 12.5;

        // double a = width * high * 2;
        // double b = length * high * 2;
        // sum = a + b;

        // Console.WriteLine("a " + a + " " + "b " + b + " suma " + sum);

        // int a = 2;
        // int b = -11;
        // int c = 12;
        // int delta;

        // delta = b * b - 4 * a * c;
        // double zeroPOint = (-b + Math.Sqrt(delta))/(2*a);
        // double zeroPOintTwo = (-b - Math.Sqrt(delta))/(2*a);

        // Console.WriteLine(delta);
        // if(delta > 0){
        //     Console.WriteLine("Funkcja ma dwa miejsce zerowe");
        //     Console.WriteLine(zeroPOint);
        //     Console.WriteLine(zeroPOintTwo);
        // }else if(delta == 0){
        //     Console.WriteLine("Fukcja posiada jedno miejsce zerowe");
        //     Console.WriteLine(zeroPOint);
        // }else {

        //     Console.WriteLine("Funkcja nie posiada miejsca zerowego");
        // }

        int godziny = 9;
        int minuty = 30;

        if((godziny == 8) && (minuty <= 20) || (godziny < 8)){
            Console.WriteLine("Nie jesteś spóźniony");
        }else {
            Console.WriteLine("O nie ! jestem spóźniony");
        }
        

            


        }

    }
}
