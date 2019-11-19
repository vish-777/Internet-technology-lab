using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public int counter;
        HttpCookie cook;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
             //   return;

            cook = Request.Cookies.Get("gochi_cookie");
            if (cook != null)
            {
                int temp;
                int.TryParse(cook["counter"], out temp);
                counter = temp;
            }

            if (Session["deets"] != null)
            {
                string[] arr = (string[])Session["deets"];
                Label1.Text = String.Format("{0} Rollnumber:{1} Subject:{2}", arr[0], arr[1], arr[2]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (cook == null)
                cook = new HttpCookie("gochi_cookie");
            cook["counter"] = counter.ToString();
            Response.Cookies.Add(cook);
            Label2.Text = "Button clicked: " + counter.ToString() + "times";
        }
    }
}