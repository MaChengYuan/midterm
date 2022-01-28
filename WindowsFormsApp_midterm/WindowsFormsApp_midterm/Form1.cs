using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_midterm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string strSQL;
        public static Form1 instance;
        public Label label;
        

        public List<string> orderlist = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
            customize();
            instance = this;
            label = lbl_client;
            

            


        }

        private void customize()
        {
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void BTN_MENU_Click(object sender, EventArgs e)
        {
            if(panel3.Visible == false)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void BTN_FUNCTION_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb;
            string mydbconnectingstring = "";
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            mydbconnectingstring = scsb.ToString();



            if (globarvar.name != null)
            {

                con = new SqlConnection(mydbconnectingstring);
                con.Open();
                strSQL = "SELECT TOP 1 id FROM order_history where name = @Name ORDER BY ID DESC";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Name", globarvar.name);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    globarvar.history.Add(Convert.ToInt32($"{reader["id"]}"));
                   
                   

                }
                reader.Close();

               

            }

            if (globarvar.name != null)
            {
                BTN_login.Enabled = false;
               

            }
            

        }

        private Form activeform = null;
        private void openform(Form child)
        {
            if (activeform != null)
                activeform.Close();

            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel6.Controls.Add(child);
            panel6.Tag = child;
            child.BringToFront();
            activeform.Show();
        }

        private void BTN_ORIGINAL_Click(object sender, EventArgs e)
        {
            openform(new original());
        }

        private void BTN_CLASSIC_Click(object sender, EventArgs e)
        {
            openform(new classic());
        }

        private void BTN_SELLER_Click(object sender, EventArgs e)
        {
            Form item = new LOG_IN();
            item.Show();
            this.Hide();

           
        }

        private void BTN_RECORD_Click(object sender, EventArgs e)
        {
            openform(new record());
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openform(new history());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form item = new register();
            item.Show();
            this.Hide();
        }
    }
}
