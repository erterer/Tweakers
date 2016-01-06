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
        public string Naam { get; set; }

        public Product(string naam)
        {
            Naam = naam;
            types = new List<ProductUitvoering>();
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
