using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

namespace opdracht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var menus = new List<Item>  
        {  
            new Item() { Name="plat water", Price = 1},  
            new Item() { Name="cola (25cl)", Price = 1.5},  
            new Item() { Name="cola (33cl)", Price = 2},  
            new Item() { Name="witte wijn", Price = 3},  
            new Item() { Name="pils", Price = 2},  
            new Item() { Name="toast", Price = 5},  
            new Item() { Name="kaasplank", Price = 4}
        };  
  
    foreach (Item menu in menus)  
    {  
        Console.WriteLine(menu.Name + "  " + menu.Price);  
    } 
  
    // Output:  
    //  Tadpole  400  
    //  Pinwheel  25  
    //  Milky Way  0  
    //  Andromeda  3  
        }
    }
    public class Item  
    {  
        public string Name { get; set; }  
        public double Price { get; set; }  
    }  
}
