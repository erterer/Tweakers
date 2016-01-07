using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;
using Tweakers.Data;

namespace Tweakers.Logic
{
    public class SpecificatieRepository
    {
        public List<Specificatie> Specs = new List<Specificatie>();
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
