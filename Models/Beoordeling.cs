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

        //Shop
        public Shop Shop { get; set; }

        //Product
        public ProductUitvoering Product { get; set; }

        //Beoordeling
        public int Waarde { get; set; }

        public Beoordeling(TypeBeoordeling type, Shop shop, ProductUitvoering product, int waarde)
        {
            Type = type;
            Shop = shop;
            Product = product;
            Waarde = waarde;
        }
    }
}
