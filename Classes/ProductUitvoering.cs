using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class ProductUitvoering
    {
        //Lijst voor het bijhouden van alle specificaties van een product
        private List<Specificatie> specificaties;

        //Naam van de uitvoering
        public string Naam { get; }

        //Kleur van de uitvoering
        public Color Kleur { get; }

        public ProductUitvoering(string naam, Color kleur)
        {
            Naam = naam;
            Kleur = kleur;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int GetBeoordeling(ProductUitvoering product)
        {
            throw new NotImplementedException();
        }
    }
}
