using System;

namespace Opdracht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Author author01 = new Author("Simon Demeyere", "Simon@boek.be", 'm');
            Book book01 = new Book("Boek Titel", author01, 20, 239);

            book01.print();
        }
    }
}
