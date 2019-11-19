using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q3 : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
            con.Open();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Items", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            adapter.Fill(ds, "items_full");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("UPDATE Items SET Price = @price_val WHERE Flavour = 'Vanilla'", con);
        command.Parameters.AddWithValue("@price_val",Int32.Parse(TextBox1.Text));
        //command.Parameters.AddWithValue("@city_name", ListBox1.SelectedItem.Text);
    
        SqlDataReader reader;
        reader = command.ExecuteReader();

        reader.Close();
        
        SqlCommand command1 = new SqlCommand("SELECT * FROM Items", con);
        SqlDataAdapter adapter = new SqlDataAdapter(command1);
        adapter.Fill(ds, "items_full");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        //while (reader.Read())
        //{
        //    Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        //}

        con.Close();
    }
}