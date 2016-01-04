using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    //Enum voor de verschillende soorten beoordelingen
    public enum TypeBeoordeling
    {
        Gebruiker,
        Product,
        Shop
    }

    public class Beoordeling
    {
        //Soort beoordeling
        public TypeBeoordeling Type { get; set; }

        //Gebruiker
        public Gebruiker Gebruiker { get; set; }

        //Shop
        public Shop Shop { get; set; }

        //Product
        public ProductUitvoering Product { get; set; }

        //Beoordeling
        public int Waarde { get; set; }

        public Beoordeling(TypeBeoordeling type, Gebruiker gebruiker, Shop shop, ProductUitvoering product, int waarde)
        {
            Type = type;
            Gebruiker = gebruiker;
            Shop = shop;
            Product = product;
            Waarde = waarde;
        }
    }
}
