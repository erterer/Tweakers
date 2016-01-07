using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tweakers
{
    public partial class Koelkasten : System.Web.UI.Page
    {
        private List<ProductUitvoering> producten;
        private ProductRepository repo;

        protected void Page_Load(object sender, EventArgs e)
        {
            producten = new List<ProductUitvoering>();
            repo = new ProductRepository(new ProductOracleContext());
            Refresh();
        }
        public void Refresh()
        {
            Remove();
            repo.GetAllKoelkasten();
            producten = repo._producten;

            foreach (var p in producten)
            {
                TableCell c1 = new TableCell();
                c1.Text = p.Naam;

                TableCell c2 = new TableCell();
                c2.Text = p.Uitvoering;

                TableCell c3 = new TableCell();
                c3.Text = p.Kleur;

                HyperLink l = new HyperLink();
                l.Text = "View";
                l.NavigateUrl = "~/Producten/" + p.Naam + ".aspx";

                TableCell c4 = new TableCell();
                c4.Controls.Add(l);

                //TableHeaderCell1.Text = "Naam";
                //TableHeaderCell2.Text = "Uitvoering";
                //TableHeaderCell3.Text = "Kleur";
                //TableHeaderCell4.Text = "Specificaties";

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);
                row.Controls.Add(c3);
                row.Controls.Add(c4);

                TableKoelkasten.Controls.Add(row);
            }
        }

        /// <summary>
        /// De tabel en tijdelijke lijst worden leeggemaakt
        /// </summary>
        public void Remove()
        {
            producten.Clear();
            TableKoelkasten.Rows.Clear();
        }
    }
}