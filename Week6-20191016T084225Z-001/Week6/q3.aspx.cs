using System;
using System.Web.UI;

namespace Week6
{
    public partial class q3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["c"] = "Summer";
                DropDownList1.Items.Add("Summer");
                DropDownList1.Items.Add("Monsoon");
            }
        }
        protected void Change(object sender, EventArgs e)
        {
            Session["c"] = DropDownList1.SelectedValue;
            Response.Redirect("q3.aspx");
        }
        protected void Page_PreInit()
        {
           if(Session["c"] != null)
                Page.Theme = Session["c"].ToString();
        }
    }
}