using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class L9Q2P1 : System.Web.UI.Page
{
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = ListBox1.SelectedItem.Text;
        Response.Redirect("~/L9Q2P2.aspx?Place=" + ListBox1.SelectedItem.Text);
    }
}