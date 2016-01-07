using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
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
