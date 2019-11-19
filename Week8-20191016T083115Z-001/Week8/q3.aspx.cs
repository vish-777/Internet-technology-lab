using System;
using System.Data.SqlClient;

namespace Week8
{
    public partial class q3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Change(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update Items set price=@price where flavour=@flavour", con);
                com.Parameters.AddWithValue("@price", TextBox1.Text);
                com.Parameters.AddWithValue("@flavour", "Vanilla");
                com.ExecuteNonQuery();
                SqlCommand com2 = new SqlCommand("select price from Items where flavour=@flavour", con);
                com2.Parameters.AddWithValue("@flavour", "Vanilla");
                SqlDataReader reader = com2.ExecuteReader();
                while(reader.Read())
                {
                    Label1.Text = "The new price is " + reader["price"];
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
    }
}