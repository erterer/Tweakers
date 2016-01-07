using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Tweakers.Classes;
using Tweakers.Data;

namespace Tweakers.Data
{
    public class SpecificatieOracleContext : ISpecificatie
    {
        private Database database;

        public SpecificatieOracleContext()
        {
            database = new Database();
        }

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
