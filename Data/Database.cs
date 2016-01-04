using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Tweakers.Data
{
    public class Database
    {
        private OracleConnection conn;
        private OracleCommand command;
        private string user = "dbi334041"; //User name of the database
        private string pw = "EG4DSBe1fC"; // password of the database
        private string dataSource = "//192.168.15.50:1521/fhictora";


        public Database()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User id=" + user + ";Password=" + pw + ";Data Source=" + dataSource + ";";
        }

        public OracleCommand CreateOracleCommand(string sql)
        {

            OracleCommand command = new OracleCommand(sql, this.conn);
            command.CommandType = System.Data.CommandType.Text;

            return command;
        }
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
            catch { return null; }
        }
        public OracleDataReader ExecuteQuery(OracleCommand command)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                // reader.Read();
                return reader;
            }
            catch { return null; }
        }
        public bool ExecuteNonQuery(OracleCommand command)
        {
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }
    }
}
