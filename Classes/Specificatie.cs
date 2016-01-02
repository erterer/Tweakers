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
        private string Naam { get; set; }

        //Waarde van de bijbehorende specificatie
        private string Waarde { get; set; }

        public Specificatie(string naam, string waarde)
        {
            Naam = naam;
            Waarde = waarde;
        }
    }
}
