using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweakers.Classes
{
    public class ProductUitvoering : Product
    {
        //Naam van de uitvoering
        public string Uitvoering { get; }

        //Kleur van de uitvoering
        public string Kleur { get; }

        public ProductUitvoering(string naam, string uitvoering, string kleur)
            : base(naam)
        {
            Uitvoering = uitvoering;
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
