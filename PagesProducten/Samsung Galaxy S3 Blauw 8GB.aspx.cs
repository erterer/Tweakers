using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers.PagesProducten
{
    public partial class Samsung_Galaxy_S3_Blauw_8GB : System.Web.UI.Page
    {
        //Bool om te kijken of er specs zijn
        public string NotAvailable { get; set; }

        //Lijst met de specificaties
        private List<Specificatie> specs = new List<Specificatie>();

        //Repository
        private SpecificatieRepository repo = new SpecificatieRepository(new SpecificatieOracleContext());

        /// <summary>
        /// Laden van de webpagina
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            repo.GetAllSpecificaties("Samsung Galaxy S3 Blauw 8GB");
            specs = repo.Specs;

            //Maken van de tabel
            foreach (var s in specs)
            {
                TableCell c1 = new TableCell();
                c1.Text = s.Naam;

                TableCell c2 = new TableCell();
                c2.Text = s.Waarde;

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);

                TableSamsungS31.Controls.Add(row);
            }

            //Controleren of er specificaties zijn
            if (specs.Count == 0)
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