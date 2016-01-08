using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers.PagesProducten
{
    public partial class Samsung_Galaxy_S6_Blauw_32GB : System.Web.UI.Page
    {
        //Bool om te controleren of er specs zijn
        public string NotAvailable { get; set; }

        //Lijst met alle specificaties
        private List<Specificatie> specs = new List<Specificatie>();

        //Repository voor de specs
        private SpecificatieRepository repo = new SpecificatieRepository(new SpecificatieOracleContext());

        /// <summary>
        /// Laden van de webpagina
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            repo.GetAllSpecificaties("Samsung Galaxy S6 Blauw 32GB");
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

                TableSamsungS61.Controls.Add(row);
            }

            //Controleren of er specs beschikbaar zijn
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