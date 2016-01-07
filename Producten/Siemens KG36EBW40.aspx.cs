using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;

namespace Tweakers.Producten
{
    public partial class Siemens_KG36EBW40 : System.Web.UI.Page
    {
        private List<Specificatie> specs;
        private SpecificatieRepository repo;

        protected void Page_Load(object sender, EventArgs e)
        {
            specs.Clear();
            TableSiemens.Rows.Clear();
            repo.GetAllSpecificaties("Siemens KG36EBW40");
            specs = repo._specs;

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
        }
    }
}