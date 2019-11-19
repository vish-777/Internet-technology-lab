using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w6q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string[] ss = { null, "Summer", "Monsoon" };
            foreach(string s in ss)
                DropDownList1.Items.Add(s);                
        }

        protected void Page_PreInit(object o, EventArgs e)
        {
            if (Session["Theme"] == null) return;
            Page.Theme = Session["Theme"].ToString();
        }

        protected void myFunction(object sender, EventArgs e)
        {
            Session["Theme"] = DropDownList1.SelectedItem.Text;
            Server.Transfer("WebForm1.aspx");
        }

    }
}