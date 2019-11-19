using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string[] sub = { "EOM", "DCC", "IT", "NLP", "SNA", "SCP" };
            foreach (string s in sub)
                DropDownList1.Items.Add(s);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            string[] arr=new string[3];
            arr[0] = TextBox1.Text;
            arr[1] = TextBox2.Text;
            arr[2] = DropDownList1.SelectedItem.Text;
            if (arr[0]=="" || arr[1] == "" || arr[2] == "")
                return;
            Session["deets"] = arr;
            Response.Redirect("second.aspx");
        }
    }
}