using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Categorie
    {
        //Lijst voor alle producten die in een bepaalde categorie zitten
        private List<Product> Producten;

        //Naam van de categorie
        private string Naam { get; }

        //Zetten van de naam en aanmaken van de lijst
        public Categorie(string naam)
        {
            Naam = naam;
            Producten = new List<Product>();
        }
    }
}
