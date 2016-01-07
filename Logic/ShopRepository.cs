using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Data;
using Tweakers.Classes;

namespace Tweakers.Logic
{
    public class ShopRepository
    {
        private IShop context;
        public List<Shop> Shops = new List<Shop>();

        /// <summary>
        /// Aanmaken van de repository en de verwijzing naar de methodes
        /// </summary>
        /// <param name="context">Initialisatie van de interface</param>
        public ShopRepository(IShop context)
        {
            this.context = context;
        }

        /// <summary>
        /// Opvragen van alle winkels die in de database staan opgeslagen
        /// </summary>
        /// <returns>:Lijst met de winkels</returns>
        public bool GetAllShops()
        {
            return context.GetAllShops(out Shops);
        }

        /// <summary>
        /// Een winkel toevoegen aan de database
        /// </summary>
        /// <param name="naam">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        public bool AddShop(string naam)
        {
            return context.AddShop(naam);
        }

        /// <summary>
        /// Een winkel verwijderen van de database
        /// </summary>
        /// <param name="naam">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        public bool RemoveShop(string naam)
        {
            return context.RemoveShop(naam);
        }
    }
}
