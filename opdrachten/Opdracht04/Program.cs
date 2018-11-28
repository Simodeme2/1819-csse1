using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem(12, "Steak"));
            list.Add(new MenuItem(2, "Koffie"));
            list.Add(new MenuItem(1, "Cola"));
            list.Add(new MenuItem(15, "EUR", "Friet met stoofvlees", "Voedsel"));
            list.Add(new MenuItem(6, "EUR", "Friet en worst", "Voedsel"));
            list.Add(new MenuItem(11, "EUR", "pasta", "Voedsel"));
            list.Add(new MenuItem(30, "EUR", "Cote a los", "Voedsel"));
            list.Add(new MenuItem(2, "EUR", "Sprite", "drank"));
            list.Add(new MenuItem(5, "EUR", "Pita", "Voedsel"));
            list.Add(new MenuItem(5, "EUR", "Friet met frikandel", "Voedsel"));

            
            foreach(MenuItem item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
