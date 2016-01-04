using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public class GebruikerOracleContext : IGebruiker
    {
        Database database = new Database();
        private OracleConnection conn;
        private OracleCommand command;

        public bool AddGebruiker(Gebruiker gebruiker)
        {
            try
            {
                string query = "INSERT INTO GEBRUIKER(Username, Wachtwoord, Naam, Email, Geboortedatum, Beoordeling)" +
                    "VALUES(:Username, :Wachtwoord, :Naam, :Email, :Geboortedatum, null)";
                OracleCommand command = database.CreateOracleCommand(query);
                command.Parameters.Add("Username", gebruiker.Gebruikersnaam);
                command.Parameters.Add("Wachtwoord", gebruiker.Wachtwoord);
                command.Parameters.Add("Naam", gebruiker.Naam);
                command.Parameters.Add("Email", gebruiker.Email);
                command.Parameters.Add("Geboortedatum", gebruiker.Geboortedatum);
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

        public bool BewerkGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool OphalenGebruikers(out List<Gebruiker> gebruikers)
        {
            gebruikers = null;
            try
            {
                string query = "SELECT USERNAME, WACHTWOORD, NAAM, EMAIL, GEBOORTEDATUM FROM GERBUIKER";
                OracleCommand command = database.CreateOracleCommand(query);
                List<OracleDataReader> datareaders = database.ExecuteMultiQuery(command);
                foreach (OracleDataReader o in datareaders)
                {
                    string gebruikersnaam = (string)o["USERNAME"];
                    string wachtwoord = (string)o["WACHTWOORD"];
                    string naam = (string)o["NAAM"];
                    string email = (string)o["EMAIL"];
                    DateTime geboortedatum = (DateTime)o["GEBOORTEDATUM"];
                    int beoordeling = (int)o["BEOORDELING"];
                    gebruikers.Add(new Gebruiker(gebruikersnaam, wachtwoord, naam, email, geboortedatum, beoordeling));
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
