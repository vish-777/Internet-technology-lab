using System;

namespace Week6
{
    public partial class q4b : System.Web.UI.Page
    {
        String[,] specs = { { "3.27 inches", "4GB", "3.15MP", "1300mAh" }, { "3.8 inches", "8GB", "5MP", "1300mAh" }, { "4.7 inches", "16GB", "6.5MP", "2200mAh" }, { "5.5 inches", "32GB", "16MP", "3000mAh" }, { "6 inches", "64GB", "13MP", "5000mAh" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            String model = Label1.Text = Request.QueryString["model"];
            int num = Convert.ToInt32(Request.QueryString["num"]);
            Label2.Text = "Screen size: " + specs[num, 0] + "<br>Memory: " + specs[num, 1] + "<br>Camera: " + specs[num, 2] + "<br>Battery: " + specs[num, 3];
        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("q4a.aspx");
        }
    }
}