using System;
using System.Data;
using System.Data.SqlClient;

namespace Week8
{
    public partial class q1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT StaffID from Staff", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    adapter.Fill(ds, "staff_ids");
                    //Label1.Text = ds;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        DropDownList1.Items.Add(ds.Tables[0].Rows[i]["StaffID"].ToString());
                    
                }
                catch(Exception ex)
                {
                    Label1.Text = ex.ToString();
                }
                finally
                {
                    con.Close();
                }
                String[] cities = { "Mumbai", "Delhi", "Kolkata", "Bangalore" };
                foreach(String i in cities)
                    ListBox1.Items.Add(i);
            }
        }
        protected void Update(object sender, EventArgs e)
        {
            String city = ListBox1.SelectedValue;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE Staff SET City = '" + ListBox1.SelectedValue + "' where StaffID = " + DropDownList1.SelectedValue, con);
                com.ExecuteNonQuery();
                SqlCommand com2 = new SqlCommand("SELECT * from Staff where StaffID=" + DropDownList1.SelectedValue, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com2);
                adapter.Fill(ds, "data");
                Label1.Text = "First Name: " + ds.Tables["data"].Rows[0]["FirstName"].ToString() + "<br>Last Name: " + ds.Tables["data"].Rows[0]["LastName"].ToString() + "<br>DNo: " + ds.Tables["data"].Rows[0]["DNo"].ToString() + "<br>Street: " + ds.Tables["data"].Rows[0]["Street"].ToString() + "<br>City: " + ds.Tables["data"].Rows[0]["City"].ToString() + "<br>State: " + ds.Tables["data"].Rows[0]["State"].ToString() + "<br>ZipCode: " + ds.Tables["data"].Rows[0]["ZipCode"];
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
        protected void Change(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * from Staff where StaffID="+DropDownList1.SelectedValue, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(ds, "data");
                Label1.Text = "First Name: " + ds.Tables["data"].Rows[0]["FirstName"].ToString() + "<br>Last Name: " + ds.Tables["data"].Rows[0]["LastName"].ToString() + "<br>DNo: " + ds.Tables["data"].Rows[0]["DNo"].ToString() + "<br>Street: " + ds.Tables["data"].Rows[0]["Street"].ToString() + "<br>City: " + ds.Tables["data"].Rows[0]["City"].ToString() + "<br>State: " + ds.Tables["data"].Rows[0]["State"].ToString() + "<br>ZipCode: " + ds.Tables["data"].Rows[0]["ZipCode"];
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