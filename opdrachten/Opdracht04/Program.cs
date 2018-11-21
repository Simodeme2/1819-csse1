using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItems menuItem = new MenuItems();
            menuItem.name = "melk";

            Console.WriteLine("Name: " + menuItem.name);

            // MenuItems.Product product = new MenuItems.Product();
            // product.name = "Taart";

            // MenuItems.Price price = new MenuItems.Price();
            // price.waarde = 24;

            // Console.WriteLine(product.name);
            // Console.WriteLine(price.waarde);
        }
    }
}
