class Product
{

    public string Name {get;set;}
    public string Type {get;set;}

    public Product() {
        this.Name = "Cola";
        this.Type = "drink";
    }

    public Product(string n) {
        this.Name = n;
        this.Type = "...";
    }

    public Product(string n, string t) {
        this.Name = n;
        this.Type = t;
    }

    public string ToString() {
        return Name + " is van het type: " + Type;
    }
}