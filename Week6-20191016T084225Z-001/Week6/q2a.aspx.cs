using System;

namespace Week6
{
    public partial class q2a : System.Web.UI.Page
    {
        String[] mvendor = { "Samsung", "Lenovo", "Apple" };
        String[] lvendor = { "Lenovo", "Sony", "Dell" };
        String[] pvendor = { "HP", "Epson", "Canon" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                for(int i=0; i<3; i++)
                {
                    DropDownList1.Items.Add(mvendor[i]);
                    DropDownList2.Items.Add(lvendor[i]);
                    DropDownList3.Items.Add(pvendor[i]);
                }
            }
        }
    }
}