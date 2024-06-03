using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HtmlPage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("App_Data/Database.mdf");
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + path);
        SqlCommand cmd = con.CreateCommand();

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        if (Request.QueryString["action"] == "GetUser")
        {
            User user = new User();
            if (Session["user"] != null)
            {
                user = (User)Session["user"];
                user.password = "";

            }
            Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(user));
            Response.End();
        }
    }
}