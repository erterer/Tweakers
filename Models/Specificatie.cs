namespace Tweakers.Classes
{
    public class Specificatie
    {
        //Naam van de specificatie
        public string Naam { get; }

        //Waarde van de bijbehorende specificatie
        public string Waarde { get; }

        /// <summary>
        /// Zetten van de specificatie
        /// </summary>
        /// <param name="naam">Naam</param>
        /// <param name="waarde">Waarde van de specificatie</param>
        public Specificatie(string naam, string waarde)
        {
            Naam = naam;
            Waarde = waarde;
        }
    }
}
