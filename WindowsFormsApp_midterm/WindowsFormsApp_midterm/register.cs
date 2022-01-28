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
    public partial class register : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        string today = DateTime.Now.ToLongDateString();

        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            //scsb.UserID = "";
            //scsb.Password = "";
            //scsb.IntegratedSecurity = false;
            myDBConnectionString = scsb.ToString();

            comboBox_STATUS.Items.Add("client");
            comboBox_STATUS.Items.Add("owner");
            comboBox_pay.Items.Add("cash");
            comboBox_pay.Items.Add("credit");
            comboBox_pay.Items.Add("electronic payment");


            if(globarvar.name != null)
            {
                btn_back.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((TXT_NAME.Text != "") && (comboBox_pay.Text != "") && (TXT_PWD.Text != "") && TXT_PWD.Text.Length > 5 && (comboBox_STATUS.Text != "") && (TXT_PHONE.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into client values(@NewName,@NewPhone,@NewPayment,@NewStatus,@NewTime,@NewPwd);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", TXT_NAME.Text);
                cmd.Parameters.AddWithValue("@NewPhone", TXT_PHONE.Text);
                cmd.Parameters.AddWithValue("@NewPwd", TXT_PWD.Text);
                cmd.Parameters.AddWithValue("@NewPayment", comboBox_pay.Text);
                cmd.Parameters.AddWithValue("@NewStatus",comboBox_STATUS.Text);
                
                cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);

                int rows = cmd.ExecuteNonQuery();
                
  
                con.Close();
                MessageBox.Show("Now You Can Log in");

                Form item = new LOG_IN();
                item.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("information is incomplete");
            }

            

           
        }

        private void TXT_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form item = new Form1();
            item.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form item = new LOG_IN();
            item.Show();
            this.Hide();
        }
    }
}
