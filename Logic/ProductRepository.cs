using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Data;
using Tweakers.Classes;

namespace Tweakers.Logic
{
    public class ProductRepository
    {
        private IProduct context;
        public List<ProductUitvoering> Producten = new List<ProductUitvoering>();

        public ProductRepository(IProduct context)
        {
            this.context = context;
        }

        public bool GetAllKoelkasten()
        {
            return context.GetAllKoelkasten(out Producten);
        }

        public bool GetAllSmartphones()
        {
            return context.GetAllSmartphones(out Producten);
        }
    }
}
