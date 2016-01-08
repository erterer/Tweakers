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
    public partial class Siemens_KG36EBW40 : System.Web.UI.Page
    {
        public string NotAvailable { get; set; }
        private List<Specificatie> specs = new List<Specificatie>();
        private SpecificatieRepository repo = new SpecificatieRepository(new SpecificatieOracleContext());

        protected void Page_Load(object sender, EventArgs e)
        {
            repo.GetAllSpecificaties("Siemens KG36EBW40");
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

                TableSiemens.Controls.Add(row);
            }
            if(specs.Count == 0)
            {
                NotAvailable = "Er zijn geen specificaties beschikbaar";
            }
            else
            {
                NotAvailable = string.Empty;
            }
        }
    }
}