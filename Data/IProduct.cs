using System.Collections.Generic;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface IProduct
    {
        /// <summary>
        /// Deze methode haalt alle smartphones op uit de database
        /// </summary>
        /// <param name="smartphones">De lijst waar alle smartphones in staan</param>
        /// <returns>Een lijst met alle smartphones</returns>
        bool GetAllSmartphones(out List<ProductUitvoering> smartphones);

        /// <summary>
        /// Deze methode haalt alle koelkasten op uit de database
        /// </summary>
        /// <param name="koelkasten">De lijst waar alle koelkasten in staan</param>
        /// <returns>Een lijst met alle koelkasten</returns>
        bool GetAllKoelkasten(out List<ProductUitvoering> koelkasten);
    }
}
