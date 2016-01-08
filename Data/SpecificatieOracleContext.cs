using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public class SpecificatieOracleContext : ISpecificatie
    {
        //Instantie van de databse
        private Database database;

        /// <summary>
        /// Hier wordt de connectie naar de database gemaakt
        /// </summary>
        public SpecificatieOracleContext()
        {
            database = new Database();
        }

        /// <summary>
        /// Deze methode geeft alle specificaties terug uit de database van een bepaald product
        /// </summary>
        /// <param name="product">Het product waarvan de specificaties moeten worden opgevraagd</param>
        /// <param name="specs">De lijst waar alle specificaties in worden opgeslagen</param>
        /// <returns>Hier wordt de lijst teruggegeven</returns>
        public bool GetAllSpecificaties(string product, out List<Specificatie> specs)
        {
            specs = new List<Specificatie>();

            try
            {
                string query = "SELECT s.NAAM, p.WAARDE FROM SPECIFICATIE s, " +
                    "PRODUCTUITVOERING_SPECIFICATIE p, PRODUCTUITVOERING u WHERE " +
                    "s.ID = p.SPECIFICATIE_ID AND u.ID = p.PRODUCTUITVOERING_ID AND " +
                    "u.UITVOERING = :product";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("product", product);
                OracleDataReader datareader = database.ExecuteQuery(command);
                while (datareader.Read())
                {
                    string naam = Convert.ToString(datareader["NAAM"]);
                    string waarde = Convert.ToString(datareader["WAARDE"]);
                    specs.Add(new Specificatie(naam, waarde));
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
    }
}
