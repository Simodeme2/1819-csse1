using System;
class Book
{
    private string name;
    private Author author;
    private double price;
    private int qtyInStock = 0;

    public Book(string name, Author author, double price, int qtyInStock)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getName()
    {
        return name;
    }

    public Author getAuthor()
    {
        return author;
    }

    public double getPrice()
    {
        return price;
    }

    public void setPrice(double price) 
    {
        this.price = price;
    }

    public int getQtyInStock()
    {
        return qtyInStock;
    }

    public void setQtyInStock()
    {
        this.qtyInStock = qtyInStock;
    }

    public void print()
    {
        Console.WriteLine(name + author.getName() + price + qtyInStock);
    }

    public string getAuthorName()
    {
        return author.getName();
    }
}