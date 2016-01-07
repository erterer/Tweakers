using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;
using Tweakers.Data;

namespace Tweakers.Logic
{
    public class SpecificatieRepository
    {
        public List<Specificatie> _specs = new List<Specificatie>();
        private ISpecificatie context;

        public SpecificatieRepository(ISpecificatie context)
        {
            this.context = context;
        }

        public bool GetAllSpecificaties(string product)
        {
            return context.GetAllSpecificaties(product, out _specs);
        }
    }
}
