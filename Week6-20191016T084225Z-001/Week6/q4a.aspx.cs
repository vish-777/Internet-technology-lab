using System;

namespace Week6
{
    public partial class q4a : System.Web.UI.Page
    {
        String[] phone = { "Samsung Galaxy Y", "Nokia Lumia 620", "Nokia Lumia 730", "Moto G4 Plus", "Asus Zenfone Max Pro M1" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (String i in phone)
                    DropDownList1.Items.Add(i);
                Label1.Text = DropDownList1.SelectedValue;
            }
        }
        protected void Submit(object sender, EventArgs e)
        {
            Response.Redirect("q4b.aspx?model="+DropDownList1.SelectedValue+"&num="+DropDownList1.SelectedIndex);
        }
        protected void Change(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}