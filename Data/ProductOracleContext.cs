using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public class ProductOracleContext : IProduct
    {
        public Database Database { get;}

        public ProductOracleContext()
        {
            Database = new Database();
        }

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
