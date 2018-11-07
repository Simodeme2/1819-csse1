using System;

namespace opdracht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            tafel(0);
            tafel(1);
            tafel(2);
            tafel(3);
            tafel(4);
            tafel(5);
            tafel(6);
            tafel(7);
            tafel(8);
            tafel(9);
            tafel(10);
        }
        static void tafel(int getal) {
            for (int teller = 0; teller <= 10; teller++) {
                int resultaat = teller * getal;
                Console.WriteLine(teller + " * " + getal + " = " + resultaat);
            }
        }
    }
}
