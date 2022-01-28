using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.net元件

namespace WindowsFormsApp_midterm
{
    public partial class LOG_IN : Form
    {
        int i = 0;
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        //string today = DateTime.Now.ToLongDateString();
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            Form item = new register();
            item.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_pwd.Text != "")
            {
                string strSQL = "select * from client where ( name = @Name and password = @pwd);";

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                cmd.Parameters.AddWithValue("@pwd", txt_pwd.Text);
               
                SqlDataReader reader = cmd.ExecuteReader();
                i = 0 ;
                while (reader.Read())
                {
                    globarvar.name = $"{reader["name"]}";
                    globarvar.phone = $"{reader["phone"]}";
                    globarvar.payment = $"{reader["payment"]}";
                    i += 1;
                }

                if (i <= 0)
                {
                    MessageBox.Show("查無此人");
                }
                else
                {
                    Form item = new Form1();
                    item.Show();
                    this.Hide();
                    Form1.instance.label.Text = "dear " + txt_name.Text;
                }

                reader.Close();


                foreach (int i in globarvar.history)
                {
                    strSQL = "select * from item_list where id = @ID";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", i);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {



                        globarvar.order_history.Add($"{reader["item"]}" + "   $" + $"{reader["price"]}");

                    }
                    reader.Close();

                }




                
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
            
           

        }

        private void LOG_IN_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            //scsb.UserID = "";
            //scsb.Password = "";
            //scsb.IntegratedSecurity = false;
            myDBConnectionString = scsb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form item = new Form1();
            item.Show();
            this.Hide();
        }
    }
}
