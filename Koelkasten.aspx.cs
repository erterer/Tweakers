using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers
{
    public partial class Koelkasten : System.Web.UI.Page
    {
        // Lijst met producten
        private List<ProductUitvoering> producten;

        //Productrepository
        private ProductRepository repo;

        /// <summary>
        /// Laden van de pagina
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            producten = new List<ProductUitvoering>();
            repo = new ProductRepository(new ProductOracleContext());
            Refresh();
        }

        /// <summary>
        /// Refreshen van de webpagina
        /// </summary>
        public void Refresh()
        {
            Remove();
            repo.GetAllKoelkasten();
            producten = repo.Producten;

            foreach (var p in producten)
            {
                //Aanmaken van de tabel
                TableCell c1 = new TableCell();
                c1.Text = p.Naam;

                TableCell c2 = new TableCell();
                c2.Text = p.Uitvoering;

                TableCell c3 = new TableCell();
                c3.Text = p.Kleur;

                HyperLink l = new HyperLink();
                l.Text = "View";
                l.NavigateUrl = "~/PagesProducten/" + p.Naam + ".aspx";

                TableCell c4 = new TableCell();
                c4.Controls.Add(l);

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