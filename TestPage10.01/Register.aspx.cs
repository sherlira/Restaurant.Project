using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public string errorMessage = "";

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Form.Count > 0)
        {
            string path = Server.MapPath("App_Data/Database.mdf");
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + path);
            SqlCommand cmd = con.CreateCommand();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userName", Request.Form["userName"]);
            cmd.Parameters.AddWithValue("@password", Request.Form["password"]);
            cmd.Parameters.AddWithValue("@email", Request.Form["email"]);
            cmd.Parameters.AddWithValue("@phoneNumber", Request.Form["phoneNumber"]);
            cmd.CommandText = "Insert into [users] (userName, password, email, phoneNumber) values(@userName, @password, @email, @phoneNumber)";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                User user = new User(Request.Form["userName"], Request.Form["password"], Request.Form["email"], Request.Form["phoneNumber"], false);
                Session["user"] = user;
                Response.Redirect("HtmlPage1.html");
            }
            catch (Exception err)
            {
                errorMessage = "Registraction failed:"+err.Message;
            }

            finally { con.Close(); }
        }
    }
}