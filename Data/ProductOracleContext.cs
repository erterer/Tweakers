using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public class ProductOracleContext : IProduct
    {
        //Database instantie
        public Database Database { get;}

        /// <summary>
        /// Aanmaken van een connectie naar de database
        /// </summary>
        public ProductOracleContext()
        {
            Database = new Database();
        }

        /// <summary>
        /// Deze methode stuurt de query naar de database om alle koelkasten op te halen
        /// </summary>
        /// <param name="koelkasten">De lijst waar alle koelkasten in worden opgeslagen</param>
        /// <returns>Hier wordt de lijst teruggegeven</returns>
        public bool GetAllKoelkasten(out List<ProductUitvoering> koelkasten)
        {
            koelkasten = new List<ProductUitvoering>();

            try
            {
                string query = "SELECT p.NAAM, u.UITVOERING, u.KLEUR FROM product p, productuitvoering u WHERE p.id = u.product_id AND p.categorie_id = 5";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    string naam = Convert.ToString(datareader["NAAM"]);
                    string uitvoering = Convert.ToString(datareader["UITVOERING"]);
                    string kleur = Convert.ToString(datareader["KLEUR"]);
                    koelkasten.Add(new ProductUitvoering(naam, uitvoering, kleur));
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        /// <summary>
        /// Deze methode stuurt de query naar de database om alle smartphones op te halen
        /// </summary>
        /// <param name="smartphones">De lijst waar alle smartphones in worden opgeslagen</param>
        /// <returns>Hier wordt de lijst teruggeven</returns>
        public bool GetAllSmartphones(out List<ProductUitvoering> smartphones)
        {
            smartphones = new List<ProductUitvoering>();

            try
            {
                string query = "SELECT p.NAAM, u.UITVOERING, u.KLEUR FROM product p, productuitvoering u WHERE p.id = u.product_id AND p.categorie_id = 2";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    string naam = Convert.ToString(datareader["NAAM"]);
                    string uitvoering = Convert.ToString(datareader["UITVOERING"]);
                    string kleur = Convert.ToString(datareader["KLEUR"]);
                    smartphones.Add(new ProductUitvoering(naam, uitvoering, kleur));
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
    }
}
