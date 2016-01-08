﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers.Producten
{
    public partial class LG_GBB539PZCFE : System.Web.UI.Page
    {
        //Boolean of er specs terugkomen
        public string NotAvailable { get; set; }
        
        //Lijst voor de specificaties 
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
            repo.GetAllSpecificaties("LG GBB539PZCFE");
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

                TableLG.Controls.Add(row);
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