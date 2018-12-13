using System;

namespace deel2
{
    public class Persoon : Gebruiker
    {
        private string naam;
        private string voornaam;
        string Naam
        { 
            get
            {
                return this.naam;
            } 
            set
            { 
                this.naam = value;
            }
        }
        public string Voornaam
        { 
            get
            {
                return this.voornaam;
            } 
            set
            {
                this.voornaam = value;
            }
        }
        public int Leeftijd()
        {
            return 18;
        }
        public string VolledigeNaam { get; }
        public DateTime Geboortedatum { get; set; }
        public override string GenereerWachtwoord()
        {
            return "Persoon - wachtwoord";
        }
        public string GenereerWachtwoord(int input)
        {
            return "test 1";
        }
        public string GenereerWachtwoord(string input)
        {
            return "test 2";
        }
        // public int GenereerWachtwoord()
        // {
        //     return 42115151;
        //
        public string ToString()
        {
            return "Waarden van object persoon";
        }
    }
}