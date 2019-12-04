using System;

namespace math_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<=10; i++){
                string space = " ";
                if(i == 1){
                    for(int j = 1; j <= 10; j++){
                        Console.Write(j + "  ");
                    }
                    Console.WriteLine(space);
                }
                if(i == 2){
                    for(int j =1;j<=20;j++){
                        if(j % 2 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 3){
                    for(int j = 1;j <= 30;j++){
                        if(j % 3 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 4){
                    for(int j = 1;j <= 40;j++){
                        if(j % 4 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 5){
                    for(int j = 1;j <= 50;j++){
                        if(j % 5 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 6){
                    for(int j = 1;j <= 60;j++){
                        if(j % 6 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 7){
                    for(int j = 1;j <= 70;j++){
                        if(j % 7 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 8){
                    for(int j = 1;j <= 80;j++){
                        if(j % 8 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 9){
                    for(int j = 1;j <= 90;j++){
                        if(j % 9 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
                if(i == 10){
                    for(int j = 1;j <= 100;j++){
                        if(j % 10 == 0){
                            Console.Write(j);
                            Console.Write("  ");
                        }
                        
                    }Console.WriteLine(space);
                }
            }
        }
    }
}
