namespace Tweakers.Classes
{
    public class Shop
    {
        /// <summary>
        /// De naam van een winkel
        /// </summary>
        public string Naam { get; }

        /// <summary>
        /// Zetten van de naam
        /// </summary>
        /// <param name="naam">Naam van de winkel</param>
        public Shop(string naam)
        {
            Naam = naam;
        }
    }
}
