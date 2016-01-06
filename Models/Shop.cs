using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="naam"></param>
        public Shop(string naam)
        {
            Naam = naam;
        }

        /// <summary>
        /// Opvragen van de beoordeling van een winkel
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public int GetBeoordeling(Shop shop)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Een product toevoegen aan een shop, hier wordt tevens de prijs meegegeven en of het product leverbaar is
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
