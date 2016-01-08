using System.Collections.Generic;
using Tweakers.Classes;
using Tweakers.Data;

namespace Tweakers.Logic
{
    public class SpecificatieRepository
    {
        //De lijst waar alle specificaties in worden opgeslagen
        public List<Specificatie> Specs = new List<Specificatie>();

        //De interface waarin alle regels staan opgeslagen
        private ISpecificatie context;

        public SpecificatieRepository(ISpecificatie context)
        {
            this.context = context;
        }

        /// <summary>
        /// Deze methode haalt alle specificaties op van een bepaald product
        /// </summary>
        /// <param name="product">Het product waarvan de specificaties moeten worden opgehaald</param>
        /// <param name="specs">De lijst met specificaties die worden teruggegeven</param>
        /// <returns>De lijst met specificaties</returns>
        public bool GetAllSpecificaties(string product)
        {
            return context.GetAllSpecificaties(product, out Specs);
        }
    }
}
