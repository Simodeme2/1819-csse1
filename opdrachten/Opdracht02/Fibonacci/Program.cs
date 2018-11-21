using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int input;
            Console.Write("1. geef een getal in: ");
            Console.Write("2. geef een getal in: ");

            input = Convert.ToInt32(Console.ReadLine());*/
            
            // Declaratie variabelen
            int teller, fibo1, fibo2, fibo3;
            fibo1 = 0;
            fibo2 = 1;

            // Eerste 2 getallen Fibonacci is 0 en 1
            Console.WriteLine(fibo1.ToString() + " " + fibo2.ToString() + " ");

            // Fibonacci berekenen tot het 30ste getal
            for (teller = 3; teller <= 30; teller++)
            {
                fibo3 = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibo3;

                // Weergave
                Console.Write(fibo3.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
