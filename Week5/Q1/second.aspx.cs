﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w5q1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            string temp = Request.QueryString["name"];
            Label1.Text = temp;
            temp = Request.QueryString["model"];
            Label2.Text = temp;
        }
    }
}