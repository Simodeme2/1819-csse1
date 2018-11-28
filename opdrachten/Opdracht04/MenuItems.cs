using System;

class MenuItem
{
    public Price Price {get; set;}
    public Product Product {get; set;}

    public MenuItem() {
        this.Price = new Price();
        this.Product = new Product();

        Console.WriteLine("Resultaat zonder parameters: " + this.ToString());
    }

    public MenuItem(double waarde, string name) {
        this.Price = new Price(waarde);
        this.Product = new Product(name);

        Console.WriteLine("Resultaat met x aantal parameters: " + this.ToString());
    }

    public MenuItem(double waarde, string valuta, string name, string type) {
        this.Price = new Price(waarde, valuta);
        this.Product = new Product(name, type);

        Console.WriteLine("Resultaat met y aantal parameters: " + this.ToString());
    }

    public string ToString()
    {
        return this.Product.ToString() + " kost " + this.Price.ToString();
    }

}