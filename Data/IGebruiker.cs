using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface IGebruiker
    {
        bool AddGebruiker(Gebruiker gebruiker);

        bool DeleteGebruiker(Gebruiker gebruiker);

        bool BewerkGebruiker(Gebruiker gebruiker);

        bool OphalenGebruikers(out List<Gebruiker> gebruikers);
    }
}
