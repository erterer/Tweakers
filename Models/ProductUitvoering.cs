namespace Tweakers.Classes
{
    public class ProductUitvoering : Product
    {
        //Naam van de uitvoering
        public string Uitvoering { get; }

        //Kleur van de uitvoering
        public string Kleur { get; }

        /// <summary>
        /// Zetten van een product
        /// </summary>
        /// <param name="naam">Naam, komt van de base</param>
        /// <param name="uitvoering">Uitvoering van een product</param>
        /// <param name="kleur">Kleur van de uitvoering</param>
        public ProductUitvoering(string naam, string uitvoering, string kleur)
            : base(naam)
        {
            Uitvoering = uitvoering;
            Kleur = kleur;
        }
    }
}
