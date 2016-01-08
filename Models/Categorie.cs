using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Categorie
    {
        //Naam van de categorie
        public string Naam { get; }

        //Zetten van de naam en aanmaken van de lijst
        public Categorie(string naam)
        {
            Naam = naam;
        }
    }
}
