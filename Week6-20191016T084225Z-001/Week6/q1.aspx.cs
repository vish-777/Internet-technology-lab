using System;
using System.Web.UI.WebControls;

namespace Week6
{
    public partial class q1 : System.Web.UI.Page
    {
        String[] names = { "A", "B", "C", "D" };
        String[] house = { "Blue", "Green", "Red", "Yellow" };
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            if(!IsPostBack)
            {
                dd1.Items.Add(new ListItem(null));
                for (int i = 0; i < 4; i++)
                {
                    dd1.Items.Add(names[i]);
                    rbl1.Items.Add(house[i]);
                }
                //dd1.SelectedIndex = -1;
            }
        }
        protected void Validate(object sender, ServerValidateEventArgs e)
        {
            if (e.Value.Length == 10)
            {
                e.IsValid = true;
                for (int i = 0; i < e.Value.Length; i++)
                {
                    if (e.Value[i] < '0' || e.Value[i] > '9')
                    {
                        e.IsValid = false;
                        break;
                    }
                }
            }
            else
                e.IsValid = false;
        }
        protected void Submit(object sender, EventArgs e)
        {
            if (Page.IsValid == true)
                Label1.Text = "Successful login";
        }
    }
}