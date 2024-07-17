using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Rogined : System.Web.UI.Page
    {

        //接続文字列
        string conn_str = "Host=localhost;Port=5432;Username=postgres;Password=playyer;Database=test";
        string receivedValue_name;
        string receivedValue_pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                BindGridView();
            }
        }

        private void BindGridView()
        {
            NpgsqlCommand cmd = null;
            string cmd_str = null;
            DataTable dt = null;
            NpgsqlDataAdapter da = null;

            using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
            {
                //PostgreSQLへ接続
                conn.Open();

                //Label2.Text = "Connection success!";

                dt = new DataTable();
                cmd_str = "SELECT * FROM test";
                cmd = new NpgsqlCommand(cmd_str, conn);
                da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                Grid1.DataSource = dt;
                Grid1.DataBind();
            }
        }

        protected void Dlt_Blt_Click(object sender, EventArgs e)
        {
            receivedValue_name = Session["value_name"].ToString();
            receivedValue_pass = Session["value_pass"].ToString();

            using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
            {
                //PostgreSQLへ接続
                conn.Open();

                string cmd_str = "DELETE FROM test WHERE 名前 LIKE @name";
                using (NpgsqlCommand cmd = new NpgsqlCommand(cmd_str, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + receivedValue_name + "%");
                    cmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("test.aspx");
        }

        protected void Btn__Click(object sender, EventArgs e)
        {
            Response.Redirect("test.aspx");
        }
    }
}