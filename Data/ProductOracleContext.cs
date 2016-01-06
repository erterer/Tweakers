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
        Database database;

        public ProductOracleContext()
        {
            database = new Database();
        }

        public bool GetAllKoelkasten(out List<ProductUitvoering> koelkasten)
        {
            koelkasten = new List<ProductUitvoering>();

            try
            {
                string query = "SELECT p.NAAM, u.UITVOERING, u.KLEUR FROM product p, productuitvoering u WHERE p.id = u.product_id AND p.categorie_id = 5";
                OracleCommand command = database.CreateOracleCommand(query);
                OracleDataReader datareader = database.ExecuteQuery(command);
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
                database.CloseConnection();
            }
        }

        public bool GetAllSmartphones(out List<ProductUitvoering> smartphones)
        {
            throw new NotImplementedException();
        }

        public bool GetAllTablets(out List<ProductUitvoering> tablets)
        {
            throw new NotImplementedException();
        }

        public bool GetAllWasmachines(out List<ProductUitvoering> wasmachines)
        {
            throw new NotImplementedException();
        }

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
                database.CloseConnection();
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
                database.CloseConnection();
            }

            try
            {
                string query = "INSERT INTO PRODUCT(id, Naam, categorie_id)" +
                    "VALUES(:id, :naam, :categorie_id)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("id", id);
                command.Parameters.Add("naam", product.Naam);
                command.Parameters.Add("categorie_id", categorie_id);
                database.OpenConnection();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                database.CloseConnection();
            }
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
                database.CloseConnection();
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
                database.CloseConnection();
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
                database.OpenConnection();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                database.CloseConnection();
            }
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
