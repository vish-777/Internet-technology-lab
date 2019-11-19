using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q4 : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("INSERT INTO Works (Name, CName, Salary) VALUES (@a,@b,@c)", con);
        command.Parameters.AddWithValue("@a",TextBox1.Text);
        command.Parameters.AddWithValue("@b", TextBox2.Text);
        command.Parameters.AddWithValue("@c", Int32.Parse(TextBox3.Text));
        //command.Parameters.AddWithValue("@city_name", ListBox1.SelectedItem.Text);

        SqlDataReader reader;
        reader = command.ExecuteReader();

        reader.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping1; Integrated Security=True";
        con.Open();
        SqlCommand command1 = new SqlCommand("SELECT Name, City FROM Works,Lives WHERE (Works.Name = Lives.PName AND CName=@com)", con);
        command1.Parameters.AddWithValue("@com", TextBox4.Text);
        SqlDataAdapter adapter = new SqlDataAdapter(command1);
        adapter.Fill(ds, "q4_full");
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}