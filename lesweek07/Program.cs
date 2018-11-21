using System;

namespace lesweek07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Voertuig auto1 = new Voertuig();
            // auto1.laadvermogen = 12;
            auto1.Laadvermogen = 12;

        }
    }

    internal class Voertuig
    {
        private string laadvermogen;
    }
}
