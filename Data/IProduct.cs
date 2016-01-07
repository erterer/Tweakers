using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface IProduct
    {
        bool GetAllSmartphones(out List<ProductUitvoering> smartphones);

        bool GetAllKoelkasten(out List<ProductUitvoering> koelkasten);
    }
}
