﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers
{
    public partial class Smartphones : System.Web.UI.Page
    {
        //Lijst met producten
        private List<ProductUitvoering> producten;

        //Productrepository
        private ProductRepository repo;

        /// <summary>
        /// Laden van de webpagina
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            producten = new List<ProductUitvoering>();
            repo = new ProductRepository(new ProductOracleContext());
            Refresh();
        }

        /// <summary>
        /// Plaatsen van de gegevens op de webpagina
        /// </summary>
        public void Refresh()
        {
            Remove();
            repo.GetAllSmartphones();
            producten = repo.Producten;

            foreach (var p in producten)
            {
                //Maken van de tabel
                TableCell c1 = new TableCell();
                c1.Text = p.Naam;

                TableCell c2 = new TableCell();
                c2.Text = p.Uitvoering;

                TableCell c3 = new TableCell();
                c3.Text = p.Kleur;

                HyperLink l = new HyperLink();
                l.Text = "View";
                l.NavigateUrl = "~/PagesProducten/" + p.Uitvoering + ".aspx";

                TableCell c4 = new TableCell();
                c4.Controls.Add(l);

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);
                row.Controls.Add(c3);
                row.Controls.Add(c4);

                TableSmartphones.Controls.Add(row);
            }
        }

        /// <summary>
        /// De tabel en tijdelijke lijst worden leeggemaakt
        /// </summary>
        public void Remove()
        {
            producten.Clear();
            TableSmartphones.Rows.Clear();
        }
    }
}