using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Product
    {
        //Naam van een product
        public string Naam { get; set; }

        /// <summary>
        /// Zetten van de naam
        /// </summary>
        /// <param name="naam">Naam</param>
        public Product(string naam)
        {
            Naam = naam;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public List<Product> VergelijkDrieProducten()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public List<Product> VergelijkTweeProducten()
        {
            throw new NotImplementedException();
        }
    }
}