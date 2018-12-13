class Author
{
    private string Name {get; set;}
    private string Email {get; set;}
    private char Gender {get; set;}

    public Author(string Name, string Email, char Gender)
    {
        this.Name = Name;
        this.Email = Email;
        this.Gender = Gender;
    }
    
    public string getName()
    {
        return this.Name;
    }
}
