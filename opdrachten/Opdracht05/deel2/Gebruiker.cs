namespace deel2
{
    public class Gebruiker : IInformatie
    {
        protected string wachtwoord;
        public string Gebruikersnaam { get; set; }
        public virtual string GenereerWachtwoord()
        {
            return "wachtwoord";
        }
        public void GenereerGebruikersnaam()
        {
            this.Gebruikersnaam = "Gebruikersnaam";
        }
        public Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }
    }
}