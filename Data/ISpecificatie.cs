using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweakers.Classes;

namespace Tweakers.Data
{
    public interface ISpecificatie
    {
        bool GetAllSpecificaties(string product, out List<Specificatie> specs);
    }
}
