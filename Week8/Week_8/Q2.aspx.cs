using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q2 : System.Web.UI.Page
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
        SqlCommand command = new SqlCommand("SELECT Name FROM Legends WHERE Category=@cat", con);
        command.Parameters.AddWithValue("@cat", DropDownList1.SelectedItem.Text);
        //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //adapter.Fill(ds, "Selected_Staff");

        // Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        SqlDataReader reader;
        reader = command.ExecuteReader();
        ListBox1.Items.Clear();
        while (reader.Read())
        {
            ListBox1.Items.Add(reader["Name"].ToString());
        }
        con.Close();
    }



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("SELECT Name, Age FROM Legends WHERE Name=@nam", con);
        command.Parameters.AddWithValue("@nam", ListBox1.SelectedItem.Text);
        //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //adapter.Fill(ds, "Selected_Staff");

        // Label1.Text = reader["FirstName"].ToString() + ", " + reader["LastName"].ToString() + ", " + reader["DNo"].ToString() + ", " + reader["ZipCode"].ToString();
        SqlDataReader reader;
        reader = command.ExecuteReader();
        //ListBox1.Items.Clear();
        while (reader.Read())
        {
            TextBox1.Text = reader["Name"].ToString() + ", " + reader["Age"].ToString();
        }
        con.Close();
    }
}