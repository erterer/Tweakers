using System.Collections.Generic;
using Tweakers.Data;
using Tweakers.Classes;

namespace Tweakers.Logic
{
    public class ProductRepository
    {
        //De interface waar alle methodes in staan die moeten worden gebruikt
        private IProduct context;

        //De lijst waar alle producten tijdelijk in worden opgeslagen
        public List<ProductUitvoering> Producten = new List<ProductUitvoering>();

        /// <summary>
        /// Aanmaken van de interface
        /// </summary>
        /// <param name="context"></param>
        public ProductRepository(IProduct context)
        {
            this.context = context;
        }

        /// <summary>
        /// Deze methode haalt alle koelkasten op uit de database
        /// </summary>
        /// <returns>Geeft alle koelkasten terug in een lijst</returns>
        public bool GetAllKoelkasten()
        {
            return context.GetAllKoelkasten(out Producten);
        }

        /// <summary>
        /// Deze methode haalt alle smartphones op uit de database
        /// </summary>
        /// <returns>Een lijst met alle smartphones</returns>
        public bool GetAllSmartphones()
        {
            return context.GetAllSmartphones(out Producten);
        }
    }
}
