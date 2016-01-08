namespace Tweakers.Classes
{
    //Enum voor de verschillende soorten beoordelingen
    public enum TypeBeoordeling
    {
        Gebruiker,
        Product,
        Shop
    }

    public class Beoordeling
    {
        //Soort beoordeling
        public TypeBeoordeling Type { get; set; }

        //Shop
        public Shop Shop { get; set; }

        //Product
        public ProductUitvoering Product { get; set; }

        //Beoordeling
        public int Waarde { get; set; }

        /// <summary>
        /// Zetten van de Beoordeling
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="shop">Shop, object</param>
        /// <param name="product">productuitvoering, object</param>
        /// <param name="waarde">waarde tussen de 1 en 5</param>
        public Beoordeling(TypeBeoordeling type, Shop shop, ProductUitvoering product, int waarde)
        {
            Type = type;
            Shop = shop;
            Product = product;
            Waarde = waarde;
        }
    }
}
