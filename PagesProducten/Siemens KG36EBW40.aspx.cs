using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers.Producten
{
    public partial class Siemens_KG36EBW40 : System.Web.UI.Page
    {
        //Bool om te controleren of er specs zijn
        public string NotAvailable { get; set; }

        //Lijst met specs
        private List<Specificatie> specs = new List<Specificatie>();

        //Repository voor specs
        private SpecificatieRepository repo = new SpecificatieRepository(new SpecificatieOracleContext());

        /// <summary>
        /// Laden van de webpagina
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            repo.GetAllSpecificaties("Siemens KG36EBW40");
            specs = repo.Specs;

            foreach (var s in specs)
            {
                //Aanmaken van de tabel
                TableCell c1 = new TableCell();
                c1.Text = s.Naam;

                TableCell c2 = new TableCell();
                c2.Text = s.Waarde;

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);

                TableSiemens.Controls.Add(row);
            }

            //Controleren of er specs zijn
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