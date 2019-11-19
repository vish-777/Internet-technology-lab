using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class L9Q4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            List<string> Category = new List<string>();
            Category.Add("Comedy");
            Category.Add("Romance");
            Category.Add("Animated");
            DropDownList1.DataSource = Category;
            this.DataBind();
        }

    }
}