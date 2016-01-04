using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Data;
using Tweakers.Classes;

namespace Tweakers.Logic
{
    public class GebruikerRepository
    {
        public IGebruiker context;

        public GebruikerRepository(IGebruiker context)
        {
            this.context = context;
        }

        public bool AddGebruiker(Gebruiker gebruiker)
        {
            return context.AddGebruiker(gebruiker);
        }

        public bool DeleteGebruiker(Gebruiker gebruiker)
        {
            return context.DeleteGebruiker(gebruiker);
        }

        public bool BewerkGebruiker(Gebruiker gebruiker)
        {
            return context.BewerkGebruiker(gebruiker);
        }
    }
}
