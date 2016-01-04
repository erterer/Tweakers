using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class Product
    {
        //Lijst voor alle uitoeringen van een product
        private List<ProductUitvoering> types;
        //Naam van een product
        private string Naam { get; }
        //Merk van het product
        private string Merk { get; }

        public Product(string naam, string merk)
        {
            Naam = naam;
            Merk = merk;
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
