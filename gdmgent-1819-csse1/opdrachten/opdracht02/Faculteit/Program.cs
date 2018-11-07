using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaratie variabelen
            int teller, getal, faculteit;
            faculteit = 1;

            // Opvragen getal aan gebruiker
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());

            // Berekening Faculteit
            for (teller = 1; teller <= getal; teller++)
            faculteit = faculteit * teller;

            // Weergave
            Console.WriteLine("De faculteit van " + getal.ToString() + " = " + faculteit.ToString());
        }
    }
}
