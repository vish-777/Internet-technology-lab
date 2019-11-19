using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w6q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string[] students = {null, "Eleven", "Mike", "Dustin", "Lucas", "Will" };
            string[] house = { "Ruby", "Emerald", "Sapphire", "Topaz" };
            foreach (string s in students)
                DropDownList1.Items.Add(s);
            foreach (string s in house)
                RadioButtonList1.Items.Add(s);
            
        }

        protected void Phone_number_validation(object sender, ServerValidateEventArgs e)
        {
            try
            {
                int val;
                int.TryParse(e.Value.Substring(0,1) , out val);
                if (val >= 6 && val <= 9)
                    e.IsValid = true;
                else
                    e.IsValid = false;
            }
            catch
            {
                e.IsValid = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
                Label1.Text = "SUCCESS";
        }
    }
}