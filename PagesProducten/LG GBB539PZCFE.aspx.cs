using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers.Producten
{
    public partial class LG_GBB539PZCFE : System.Web.UI.Page
    {
        public string NotAvailable = string.Empty;
        private List<Specificatie> specs = new List<Specificatie>();
        private SpecificatieRepository repo = new SpecificatieRepository(new SpecificatieOracleContext());

        protected void Page_Load(object sender, EventArgs e)
        {
            repo.GetAllSpecificaties("LG GBB539PZCFE");
            specs = repo.Specs;

            foreach (var s in specs)
            {
                TableCell c1 = new TableCell();
                c1.Text = s.Naam;

                TableCell c2 = new TableCell();
                c2.Text = s.Waarde;

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);

                TableLG.Controls.Add(row);
            }

            if (specs.Count == 0)
            {
                NotAvailable = "Er zijn geen specificaties beschikbaar";
            }
        }
    }
}