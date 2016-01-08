using System;

namespace Tweakers.Classes
{
    /// <summary>
    /// Enum voor het kiezen van een reviewsoort
    /// </summary>
    public enum SoortReview
    {
        Gebruiker,
        Shop,
        Product
    }

    public class Review
    {
        //Waarover gaat de review
        public SoortReview Soort { get; set; }

        //Naam review
        public string Naam { get; set; }

        //Beoordeling
        public Beoordeling Beoordeling { get; set; }

        //Opmerking
        public string Opmerking { get; set; }

        //Datum van plaatsing
        public DateTime Datum { get; set; }

        //Shop
        public Shop Shop { get; set; }

        //Product
        public ProductUitvoering Product { get; set; }

        /// <summary>
        /// Maken van een review
        /// </summary>
        /// <param name="soort">Waarover gaat het</param>
        /// <param name="naam">Reviewnaam</param>
        /// <param name="beoordeling">Object beoordeling</param>
        /// <param name="opmerking">Extra opmerkingen</param>
        /// <param name="datum">Datum</param>
        /// <param name="shop">Object winkel</param>
        /// <param name="product">Object uitvoering</param>
        public Review(SoortReview soort, string naam, Beoordeling beoordeling, string opmerking, DateTime datum, Shop shop, ProductUitvoering product)
        {
            Soort = soort;
            Beoordeling = beoordeling;
            Opmerking = opmerking;
            Datum = datum;
            Shop = shop;
            Product = product;
        }
    }
}
