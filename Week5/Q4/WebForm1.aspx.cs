using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("User1");
            DropDownList1.Items.Add("User2");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string u = DropDownList1.SelectedItem.Text;
            string p = TextBox1.Text;
            if ((u == "User1" && p == "one") || (u == "User2" && p == "two"))
                Success();
            else
                Failed();
        }

        private void Success()
        {
            Application.Lock();
            int count = 0;
            if (Application["LoginCount"] != null)
            {
                count = (int)Application["LoginCount"];
            }
            Application["LoginCount"] = count + 1;
            Application.UnLock();
            Server.Transfer("WebForm2.aspx");
        }
        private void Failed()
        {
            TextBox1.Text = "";
            int attempts = 0;
            if (Session["Attempts"] != null)
            {
                attempts = (int)Session["Attempts"];
            }
            if (attempts > 2)
                TextBox1.Enabled = false;
            Session["Attempts"] = attempts + 1;
        }

    }
}