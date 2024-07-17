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
    public partial class test_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                if (TextBox2.Text != "")
                {
                    Insert_sequence();

                    Response.Redirect("test.aspx");
                }
                else
                {
                    Label4.Text = "PASSを入力してください";
                }
            }
            else
            {
                Label4.Text = "名前を入力してください";
            }
            
        }

        private void Insert_sequence()
        {
            NpgsqlCommand cmd = null;
            string cmd_str = null;
            DataTable dt = null;
            NpgsqlDataAdapter da = null;
            int c = 0;

            //接続文字列
            string conn_str = "Host=localhost;Port=5432;Username=postgres;Password=playyer;Database=test";

            using (NpgsqlConnection conn = new NpgsqlConnection(conn_str))
            {
                //PostgreSQLへ接続
                conn.Open();

                dt = new DataTable();

                cmd_str = "SELECT * FROM test";
                cmd = new NpgsqlCommand(cmd_str, conn);
                da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                c = dt.Rows.Count + 1;

                cmd_str = "INSERT INTO test (id,名前,pass,出身地) VALUES(@id, @name, @pass, @from)";
                using (cmd = new NpgsqlCommand(cmd_str, conn))
                {
                    cmd.Parameters.AddWithValue("id", c);
                    cmd.Parameters.AddWithValue("name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("pass", TextBox2.Text);
                    cmd.Parameters.AddWithValue("from", TextBox3.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("test.aspx");
        }
    }
}