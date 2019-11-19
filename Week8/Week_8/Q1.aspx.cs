using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q1 : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE StaffID=@staff_id", con);
        command.Parameters.AddWithValue("@staff_id", DropDownList1.SelectedItem.Text);
        //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //adapter.Fill(ds, "Selected_Staff");

        // Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        SqlDataReader reader;
        reader = command.ExecuteReader();

        while (reader.Read())
        {
            Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("UPDATE Staff SET City = @city_name WHERE StaffID = @staff_id", con);
        command.Parameters.AddWithValue("@staff_id", DropDownList1.SelectedItem.Text);
        command.Parameters.AddWithValue("@city_name", ListBox1.SelectedItem.Text);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        SqlDataReader reader;
        reader = command.ExecuteReader();
     
        //while (reader.Read())
        //{
        //    Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        //}

        con.Close();
    }
}