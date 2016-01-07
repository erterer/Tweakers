using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface ISpecificatie
    {
        /// <summary>
        /// Deze methode haalt alle specificaties op van een bepaald product
        /// </summary>
        /// <param name="product">Het product waarvan de specificaties moeten worden opgehaald</param>
        /// <param name="specs">De lijst met specificaties die worden teruggegeven</param>
        /// <returns>De lijst met specificaties</returns>
        bool GetAllSpecificaties(string product, out List<Specificatie> specs);
    }
}
