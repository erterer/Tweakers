using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Shop
    {
        //Naam van de winkel
        private string Naam { get; set; }

        //Weburl van de winkel
        private string Url { get; set; }

        public Shop(string naam, string url)
        {
            Naam = naam;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public int GetBeoordeling(Shop shop)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="shop"></param>
        /// <param name="leverbaar"></param>
        /// <param name="prijs"></param>
        /// <returns></returns>
        public bool AddProductToShop(ProductUitvoering product, Shop shop, bool leverbaar, double prijs)
        {
            throw new NotImplementedException();
        }
    }
}
