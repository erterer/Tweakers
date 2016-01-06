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

        bool GetAllTablets(out List<ProductUitvoering> tablets);

        bool GetAllKoelkasten(out List<ProductUitvoering> koelkasten);

        bool GetAllWasmachines(out List<ProductUitvoering> wasmachines);

        bool AddProduct(Product product, string categorie);

        bool BewerkProduct(Product product);

        bool DeleteProduct(Product product);

        bool AddProductUitvoering(ProductUitvoering productUitvoering, string product);

        bool BewerkProductUitvoering(ProductUitvoering productUitvoering);

        bool DeleteProductUitvoering(ProductUitvoering productUitvoering);
    }
}
