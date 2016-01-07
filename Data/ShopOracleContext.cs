using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Data
{
    public class ShopOracleContext : IShop
    {
        public Database Database { get; }

        /// <summary>
        /// Constructor, hier wordt de verbinding naar de database gemaakt
        /// </summary>
        public ShopOracleContext()
        {
            Database = new Database();
        }

        /// <summary>
        /// Ophalen van alle winkels die in de database staan, er wordt een lijst
        /// teruggegeven met alle winkels
        /// </summary>
        /// <param name="shops">Output list met alle winkels</param>
        /// <returns>Lijst met alle winkels</returns>
        public bool GetAllShops(out List<Shop> shops)
        {
            shops = new List<Shop>();

            try
            {
                string query = "SELECT NAAM FROM shop";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    if (datareader["NAAM"] != System.DBNull.Value)
                    {
                        shops.Add(new Shop(Convert.ToString(datareader["NAAM"])));
                    }
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
        /// Toevoegen van een winkel, de naam wordt opgeslagen en er wordt een nieuw ID aangemaakt
        /// </summary>
        /// <param name="naam">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        public bool AddShop(string naam)
        {
            int id = 0;

            try
            {
                string query = "SELECT MAX(ID) FROM shop";
                OracleCommand command = Database.CreateOracleCommand(query);
                OracleDataReader datareader = Database.ExecuteQuery(command);
                if (command.ExecuteScalar() == System.DBNull.Value)
                {
                    id = 1;
                }
                else
                {
                    id = Convert.ToInt32(command.ExecuteScalar());
                    id++;
                }

            }
            catch
            {
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }

            try
            {
                string query = "INSERT INTO SHOP(id, naam)" +
                    "VALUES(:id, :naam)";
                OracleCommand command = Database.CreateOracleCommand(query);
                command.Parameters.Add("id", id);
                command.Parameters.Add("naam", naam);
                Database.OpenConnection();
                command.ExecuteNonQuery();
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
        /// Door middel van de naam wordt er een shop verwijderd uit de database
        /// </summary>
        /// <param name="shop">Naam van de winkel</param>
        /// <returns>True als het is gelukt, anders false</returns>
        public bool RemoveShop(string shop)
        {
            try
            {
                string query = "DELETE FROM SHOP WHERE NAAM = :naam";
                OracleCommand command = Database.CreateOracleCommand(query);
                command.Parameters.Add("naam", shop);
                Database.OpenConnection();
                command.ExecuteNonQuery();
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
