using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public string errorMessage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form.Count > 0)
        {
            string path = Server.MapPath("App_Data/Database.mdf");
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + path);
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dtusers = new DataTable();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userName", Request.Form["userName"]);
            cmd.Parameters.AddWithValue("@password", Request.Form["password"]);

            cmd.CommandText = "select * from users left join admins on userName = adminUserName where userName = @userName and password = @password;";
            try
            {
                adapter.Fill(dtusers);
                if (dtusers.Rows.Count == 1)
                {
                    User user = new User(Request.Form["userName"], Request.Form["password"], dtusers.Rows[0]["email"].ToString(), dtusers.Rows[0]["phoneNumber"].ToString(), dtusers.Rows[0]["userName"].ToString() == dtusers.Rows[0]["adminUserName"].ToString());
                    Session["user"] = user;
                    Response.Redirect("HtmlPage1.html");
                }
                else
                {
                    errorMessage = "Login failed";
                }
            }
            catch
            {
                errorMessage = "Login failed";
            }
        }
    }
}