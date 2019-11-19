using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Week8
{
    public partial class q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(0, null);
                dict.Add(1, "Comedy");
                dict.Add(2, "Romance");
                dict.Add(3, "Animated");
                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";
                DropDownList1.DataSource = dict;
                DropDownList1.DataBind();
            }
        }
        protected void Change(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select name from Legends where category=" + DropDownList1.SelectedValue, con);
                SqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    ListBox1.Items.Add(reader["name"].ToString());
                }
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
        protected void Change2(object sender, EventArgs e)
        {
            Label1.Text = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("Select name, age from Legends where category=" + DropDownList1.SelectedValue + " and name=@n", con);
                com.Parameters.AddWithValue("@n", ListBox1.SelectedValue);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Label1.Text += "Name: " + reader["name"].ToString() + "<br>Age: "+reader["age"];
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}