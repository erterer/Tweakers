using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweakers.Classes;
using Tweakers.Logic;
using Tweakers.Data;

namespace Tweakers
{
    public partial class Shops : System.Web.UI.Page
    {
        private List<Shop> shops;
        private ShopRepository repo;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            shops = new List<Shop>();
            repo = new ShopRepository(new ShopOracleContext());
            Refresh();
        }

        /// <summary>
        /// Vernieuwen van de tabel waar alle winkels in worden weergegeven
        /// </summary>
        public void Refresh()
        {
            Remove();
            repo.GetAllShops();
            shops = repo._shops;

            foreach (var s in shops)
            {
                TableCell c1 = new TableCell();
                c1.Text = s.Naam;

                HyperLink l = new HyperLink();
                l.Text = "View";
                l.NavigateUrl = "http://google.co.in/search?q=" + s.Naam;

                TableCell c2 = new TableCell();
                c2.Controls.Add(l);

                TableRow row = new TableRow();
                row.Controls.Add(c1);
                row.Controls.Add(c2);

                Table1.Controls.Add(row);
                ddl_Shops.Items.Add(s.Naam);
            }
        }

        /// <summary>
        /// De tabel, dropdownlist en tijdelijke lijst worden leeggemaakt
        /// </summary>
        public void Remove()
        {
            shops.Clear();
            Table1.Rows.Clear();
            ddl_Shops.Items.Clear();
        }

        protected void btn_ShopToevoegen_Click(object sender, EventArgs e)
        {
            repo.AddShop(tb_NewShop.Text);
            Refresh();
        }

        protected void btn_ShopVerijderen_Click(object sender, EventArgs e)
        {
            if(ddl_Shops.SelectedItem.Text != null)
            {
                repo.RemoveShop(ddl_Shops.SelectedItem.Text);
                Refresh();
            }
        }
    }
}