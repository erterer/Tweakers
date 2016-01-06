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
        Database database = new Database();
        private OracleConnection conn;
        private OracleCommand command;

        public bool AddProduct(Product product, string categorie)
        {
            int id = 0;
            int categorie_id = 0;

            try
            {
                string query = "SELECT max(id)FROM Product";
                OracleCommand command = database.CreateOracleCommand(query);
                OracleDataReader datareader = database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    if (datareader["ID"] != System.DBNull.Value)
                    {
                        id = Convert.ToInt32(datareader["ID"]);
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                string query = "SELECT id FROM categorie WHERE lower(naam) = lower(:naam)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("naam", categorie);
                OracleDataReader datareader = database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    if (datareader["ID"] != System.DBNull.Value)
                    {
                        categorie_id = Convert.ToInt32(datareader["ID"]);
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                string query = "INSERT INTO PRODUCT(id, Naam, categorie_id)" +
                    "VALUES(:id, :naam, :categorie_id)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("id", id);
                command.Parameters.Add("naam", product.Naam);
                command.Parameters.Add("categorie_id", categorie_id);
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public bool AddProductUitvoering(ProductUitvoering productUitvoering, string product)
        {
            int id = 0;
            int categorie_id = 0;

            try
            {
                string query = "SELECT max(id)FROM ProductUitvoering";
                OracleCommand command = database.CreateOracleCommand(query);
                OracleDataReader datareader = database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    if (datareader["ID"] != System.DBNull.Value)
                    {
                        id = Convert.ToInt32(datareader["ID"]);
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                string query = "SELECT id FROM product WHERE lower(naam) = lower(:naam)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("naam", product);
                OracleDataReader datareader = database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    if (datareader["ID"] != System.DBNull.Value)
                    {
                        categorie_id = Convert.ToInt32(datareader["ID"]);
                    }
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            try
            {
                string query = "INSERT INTO PRODUCTUITVOERING(id, Naam, kleur, product_id)" +
                    "VALUES(:id, :naam, :categorie_id)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("id", id);
                command.Parameters.Add("naam", productUitvoering.Naam);
                command.Parameters.Add("kleur", productUitvoering.Kleur);
                command.Parameters.Add("product_id", categorie_id);
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { conn.Close(); }
        }

        public bool BewerkProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool BewerkProductUitvoering(ProductUitvoering productUitvoering)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductUitvoering(ProductUitvoering productUitvoering)
        {
            throw new NotImplementedException();
        }
    }
}
