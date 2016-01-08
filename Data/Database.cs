using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace Tweakers.Data
{
    public class Database
    {
        //Connectie naar de database
        private OracleConnection conn;

        //Oracle commando
        private OracleCommand command;

        //Oracle username
        private string user = "dbi334041";

        //Oracle wachtwoord
        private string pw = "EG4DSBe1fC";

        //Adres fontys server
        private string dataSource = "//192.168.15.50:1521/fhictora";
        
        /// <summary>
        /// Initialisatie van de database
        /// </summary>
        public Database()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User id=" + user + ";Password=" + pw + ";Data Source=" + dataSource + ";";
        }

        /// <summary>
        /// Aanmaken van een Oracle commando
        /// </summary>
        /// <param name="sql">De inkomende SQL query</param>
        /// <returns>Het oracle commando met de query</returns>
        public OracleCommand CreateOracleCommand(string sql)
        {

            OracleCommand command = new OracleCommand(sql, this.conn);
            command.CommandType = System.Data.CommandType.Text;

            return command;
        }

        /// <summary>
        /// Een query uitvoeren die meer dan 1 row terug geeft
        /// </summary>
        /// <param name="command">Oracle commando</param>
        /// <returns>Een lijst met het resultaat wordt teruggegeven</returns>
        public List<OracleDataReader> ExecuteMultiQuery(OracleCommand command)
        {
            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                List<OracleDataReader> result = new List<OracleDataReader>();
                while (reader.Read()) result.Add(reader);
                return result;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Een query uitvoeren die 1 row teruggeeft
        /// </summary>
        /// <param name="command">Het oracle commando</param>
        /// <returns>Het resultaat wat terugkomt, 1 row</returns>
        public OracleDataReader ExecuteQuery(OracleCommand command)
        {
            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Een query dat geen resultaat terug geeft
        /// </summary>
        /// <param name="command">Het commando</param>
        /// <returns>True als het is gelukt, anders false</returns>
        public bool ExecuteNonQuery(OracleCommand command)
        {
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Sluiten van de database connectie
        /// </summary>
        public void CloseConnection()
        {
            conn.Close();
        }

        /// <summary>
        /// Openen van de database connectie
        /// Deze wordt gebruikt voor connecties vanuit een nonquery
        /// </summary>
        public void OpenConnection()
        {
            conn.Open();
        }
    }
}
