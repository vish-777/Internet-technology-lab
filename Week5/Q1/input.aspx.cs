using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string[] arr = { "Maruti", "Fiat", "Honda", "Volkswagen" };
            foreach(string s in arr)            
                DropDownList1.Items.Add(s);            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = DropDownList1.SelectedItem.Text;
            string model = TextBox1.Text;
            if (model == "" || name== "")
                return;
            string url = string.Format("second.aspx?name={0}&model={1}", Server.UrlEncode(name), Server.UrlEncode(model));
            Response.Redirect(url);
        }
    }
}