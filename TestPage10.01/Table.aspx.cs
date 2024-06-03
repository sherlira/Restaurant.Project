using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Table : System.Web.UI.Page
{
    public string errorMessage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("App_Data/Database.mdf");
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + path);
        SqlCommand cmd = con.CreateCommand();

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@name", Request.Form["name"]);
        cmd.Parameters.AddWithValue("@date", Request.Form["date"]);
        cmd.Parameters.AddWithValue("@time", Request.Form["time"]);
        cmd.Parameters.AddWithValue("@guests", Request.Form["guests"]);
        cmd.Parameters.AddWithValue("@phoneNumber", Request.Form["phoneNumber"]);
        cmd.CommandText = "Insert into [tables] (name, date, time, guests, phoneNumber) values(@name, @date, @time, @guests, @phoneNumber)";
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Redirect("Reserve.html");
        }
        catch (Exception err)
        {
            errorMessage = "Registraction failed:" + err.Message;
        }

        finally { con.Close(); }
    }

    
}