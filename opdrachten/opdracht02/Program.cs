using System;

namespace opdracht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a1 = 100;
            int a2 = 7;
            int a3 = 3;
            int x1 = a1 + a2;
            int x2 = x1 * a3;

            int b1 = 5;
            int b2 = 406;
            int b3 = 7357;
            int b4 = 69;
            int x3 = b2 + b3;
            int x4 = x3 / b4;
            int x5 = b1 * x4;

            int c1 = 73;
            int c2 = 41;
            int c3 = 39;
            int x6 = c1 * c2;
            int x7 = x6 - c3;

            int d1 = 7;
            int d2 = 8;
            int d3 = 19;
            int x8 = d1 * d2;
            int x9 = x8 - d3;

            int totaal1 = x2 + x5 + x7 + x9;

            Console.WriteLine("resultaat 1 = " + totaal1);

            int resultaat1 = som(100, 7);
            int resultaat2 = product(3, som(100, 7));
            int resultaat3 = som(406, 7357);
            int resultaat4 = quotient(som(406, 7357), 69);
            int resultaat5 = product(5, quotient(som(406, 7357), 69));
            int resultaat6 = product(73, 41);
            int resultaat7 = verschil(product(73, 41), 39);
            int resultaat8 = product(7, 8);
            int resultaat9 = verschil(product(7, 8), 19);

            int totaal2 = resultaat2 + resultaat5 + resultaat7 + resultaat9;

            Console.WriteLine("resultaat 2 = " + totaal2);

            // int totaal3 = som(som(som(product(3, som(100, 7)), product(quotient(som(406, 7357))))))

            totaal2++;
            Console.WriteLine("resultaat 3 = " + totaal2);
            if (totaal2 == 3872) {
                Console.WriteLine("Het resultaat is perfect!");
            } else if (totaal2 > 3872) {
                Console.WriteLine("Het resultaat is te groot!");
            } else {
                Console.WriteLine("Het resultaat is niet correct!");
            }

            for (int teller = 0; teller <= 10; teller++) {
                Console.WriteLine("De teller is nu: " + teller);
            }


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


            int getal3 = 4;
            do {
                Console.WriteLine("De waarde van het getal is: " + getal3);
                getal3++;
            } while (getal3 < 5);


            int getal4 = 4;
            while (getal4 < 5) {
                Console.WriteLine("De waarde van het getal is: " + getal3);
                getal4++;
            }
        }

        static void tafel(int getal) {
            for (int teller = 0; teller <= 10; teller++) {
                int resultaat = teller * getal;
                Console.WriteLine(teller + " * " + getal + " = " + resultaat);
            }
        }
        
        static int som(int getal1, int getal2) {
            return getal1 + getal2;
        }
        static int verschil(int getal1, int getal2) {
            return getal1 - getal2;
        }
        static int product(int getal1, int getal2) {
            return getal1 * getal2;
        }
        static int quotient(int getal1, int getal2) {
            return getal1 / getal2;
        }
    }
}
