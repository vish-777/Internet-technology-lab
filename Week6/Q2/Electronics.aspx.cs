using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w6q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string[] laptops = { "HP", "Dell", "AlienWare" };
            string[] mobiles = { "Samsung", "Huawei","Xiaomi" };
            string[] printers = { "HP1", "HP2", "HP3" };
            for(int i = 0; i < 3; i++)
            {
                DropDownList2.Items.Add(mobiles[i]);
                DropDownList1.Items.Add(laptops[i]);
                DropDownList3.Items.Add(printers[i]);
            }
        }
    }
}