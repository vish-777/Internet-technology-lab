using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //populate sales id drop down list
            {
                string s = null;
                ddl.Items.Add(s);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=exampledb; Integrated Security=True;Pooling=False";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT DISTINCT sales_id from sales_detail", con);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ddl.Items.Add(reader["sales_id"].ToString());
                    }
                }
                catch (Exception ex)
                { }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source= (localdb)\MSSQLLocalDB;Initial Catalog=exampledb; Integrated Security=True; Pooling=False";
            SqlCommand command = new SqlCommand("SELECT item_name, item_amt, qty FROM sales_detail where sales_id = @sales_id", con);
            command.Parameters.AddWithValue("@sales_id", ddl.SelectedItem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // All the information in transferred with one command.
            // This command creates a new DataTable (named sales_details)
            // inside the DataSet.
            adapter.Fill(ds, "sales_details");
            grid.DataSource = ds;
            grid.DataBind();
        }
    }
}