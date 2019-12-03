using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 21;
            int suma = 0;

            for(int i = 1;i <=n; i++){
            if(i % 3 != 0)
                continue; // przejdź do następnego kroku pętli i zignoruj  polecania poniżej
                suma = suma + i;
            }
            Console.WriteLine("Suma liczb podzielnych przez 3 wynosi: " + suma + " dla n = " + n);

        }
    }
}
