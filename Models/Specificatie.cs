using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Specificatie
    {
        //Naam van de specificatie
        public string Naam { get; }

        //Waarde van de bijbehorende specificatie
        public string Waarde { get; }

        public Specificatie(string naam, string waarde)
        {
            Naam = naam;
            Waarde = waarde;
        }
    }
}
