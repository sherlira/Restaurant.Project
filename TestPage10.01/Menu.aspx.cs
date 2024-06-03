using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;

public partial class Menu : System.Web.UI.Page
{
    class Item
    {
        public string name { get; set; }
        public string src { get; set; }
        public string pos { get; set; }
        public int price { get; set; }
    }
        protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("App_Data/Database.mdf");
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + path);
        SqlCommand cmd = con.CreateCommand();

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        if (Request.QueryString["action"] == "getItem")
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from items;";
            adapter.Fill(dt);

            List<Item> items = new List<Item>();
            foreach (DataRow dr in dt.Rows)
            {
                items.Add(new Item
                {
                    name = dr["name"].ToString(),   
                    src = dr["src"].ToString(),
                    pos = dr["pos"].ToString(),
                    price = (int)dr["price"]
                });
            }
            Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(items));
            Response.End();
        }
        if (Request.QueryString["action"] == "addItem")
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", Request.QueryString["name"]);
            cmd.Parameters.AddWithValue("@src", Request.QueryString["src"]);
            cmd.Parameters.AddWithValue("@pos", Request.QueryString["pos"]);
            cmd.Parameters.AddWithValue("@price", Request.QueryString["price"]);

            cmd.CommandText = "Insert into items (name, src, pos, price) values(@name, @src, @pos, @price)";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("ok");
            Response.End();
        }
        if (Request.QueryString["action"] == "deleteItem")
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@src", Request.QueryString["src"]);

            cmd.CommandText = "delete from items where src = @src";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("ok");
            Response.End();
        }
    }
}