using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface IShop
    {
        /// <summary>
        /// Ophalen van alle winkels uit de database
        /// </summary>
        /// <param name="shops">Output list met alle winkels</param>
        /// <returns>Lijst met alle winkels</returns>
        bool GetAllShops(out List<Shop> shops);

        /// <summary>
        /// Toevoegen van een nieuwe winkel aan de database
        /// </summary>
        /// <param name="naam">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        bool AddShop(string naam);

        /// <summary>
        /// Een winkel verwijderen uit de database
        /// </summary>
        /// <param name="shop">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        bool RemoveShop(string shop);
    }
}
