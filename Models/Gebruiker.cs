using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Gebruiker
    {
        //Inlognaam van een gebruiker
        public string Gebruikersnaam { get; set; }

        //Wachtwoord van een gebruiker
        public string Wachtwoord { get; }

        //Naam van de gebruiker
        public string Naam { get; set; }

        //Email van de gebruiker
        public string Email { get; set; }

        //Geboortedatum van de gebruiker
        public DateTime Geboortedatum { get; set; }

        public int Beoordeling { get; set; }
        
        public Gebruiker(string gebruikersnaam, string wachtwoord, string naam, string email, DateTime geboortedatum, int beoordeling)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            Naam = naam;
            Email = email;
            Geboortedatum = geboortedatum;
            Beoordeling = beoordeling;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gebruiker"></param>
        /// <returns></returns>
        public int GetBeoordeling(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }
    }
}
