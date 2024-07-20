using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        List<string> nameList = new List<string>();
        List<string> passList = new List<string>();
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


            //接続文字列
            string conn_str = "Host=localhost;Port=5432;Username=postgres;Password=playyer;Database=test";

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


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nameList.Add(dt.Rows[i][1].ToString());
                    passList.Add(dt.Rows[i][2].ToString());

                }

                
            }
        }

        

        protected void Bt_2_Click(object sender, EventArgs e)
        {
            Response.Redirect("test_2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Login_sequence();
        }

        private void Login_sequence()
        {
            NpgsqlCommand cmd = null;
            string cmd_str = null;
            DataTable dt = null;
            NpgsqlDataAdapter da = null;

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

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nameList.Add(dt.Rows[i][1].ToString());
                    passList.Add(dt.Rows[i][2].ToString());
                }

                int c = nameList.Count;

                for (int i = 0; i < nameList.Count; i++)
                {

                    if (TextBox1.Text == nameList[i])
                    {
                        if (TextBox2.Text == passList[i])
                        {
                            // 二つの値をセッションに保存
                            Session["value_name"] = TextBox1.Text;
                            Session["value_pass"] = TextBox2.Text;
                            Response.Redirect("Rogined.aspx");
                        }
                        else
                        {
                            Label3.Text = "PASSが間違っています";
                            if (i == nameList.Count - 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Label3.Text = "IDが間違っています";
                        if (i == nameList.Count - 1)
                        {
                            break;
                        }
                    }
                }
            }
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}