using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q3
{    
    public partial class WebForm1 : System.Web.UI.Page
    {
        HttpCookie cook;
        protected void Page_Load(object sender, EventArgs e)
        {
            cook = Request.Cookies.Get("gochi_cookie");
            if (cook != null)
            {
                TextBox1.Text = cook["name"];
                Label2.Text = cook["name"];
                Label1.Text = cook["cart"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (cook == null)
            {
                cook = new HttpCookie("gochi_cookie");
                cook["name"] = TextBox1.Text;
                cook["cart"] = TextBox2.Text;
                Label2.Text = cook["name"];
                Label1.Text = cook["cart"];
            }
            else
            {               
                cook["name"] = TextBox1.Text;
                string temp = cook["cart"];
                temp = temp + ", ";
                temp = temp + TextBox2.Text;
                cook["cart"] = temp;
                TextBox1.Text = cook["name"];
                Label2.Text = cook["name"];
                Label1.Text = cook["cart"];
                Label1.Text = cook["cart"];
            }

            Response.Cookies.Add(cook);
        }
    }
}