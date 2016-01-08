using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class ProductShopDetails
    {
        //Prijs van het product bij een bepaalde shop
        public double Prijs { get; set; }

        //Is het product leverbaar
        public bool Leverbaar { get; set; }

        //Het product
        public ProductUitvoering Product { get; set; }

        //De winkel
        public Shop Shop { get; set; }

        /// <summary>
        /// Koppelen van de shops en producten
        /// </summary>
        /// <param name="prijs">Prijs</param>
        /// <param name="leverbaar">Is het leverbaar</param>
        /// <param name="product">Het product wat wordt gekoppeld</param>
        /// <param name="shop">De shop wat wordt gekoppeld</param>
        public ProductShopDetails(double prijs, bool leverbaar, ProductUitvoering product, Shop shop)
        {
            Prijs = prijs;
            Leverbaar = leverbaar;
            Product = product;
            Shop = shop;
        }
    }
}
