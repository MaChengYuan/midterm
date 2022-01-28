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
    public partial class record : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectingstring = "";
        int sum = 0;
        public record()
        {
            InitializeComponent();
        }

        private void record_Load(object sender, EventArgs e)
        {
            
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectingstring = scsb.ToString();

            foreach (string i in globarvar.orderlist)
            {
                listBox_orderlist.Items.Add(i);
            }



            foreach (int i in globarvar.price)
            {
                sum += i;
            }

            label_sum.Text = "$ " + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_orderlist.Items.Clear();
            globarvar.orderlist.Clear();
            globarvar.goods.Clear();
            globarvar.price.Clear();
            sum = 0;
            label_sum.Text = "$ " + sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox_orderlist.SelectedIndex;
            listBox_orderlist.Items.RemoveAt(index);
            globarvar.orderlist.RemoveAt(index);
            globarvar.goods.RemoveAt(index);
            sum = sum - globarvar.price[index];
            label_sum.Text = "$ " + sum.ToString();
            globarvar.price.RemoveAt(index);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            string strSQL;

            if (globarvar.name != null)
            {
                if ((listBox_orderlist != null))
                {
                    con = new SqlConnection(myDBConnectingstring);
                    con.Open();
                    strSQL = "insert into order_history values(@NewName,@NewPhone,@NewPayment,@NewTime);";
                    cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@NewName", globarvar.name);
                    cmd.Parameters.AddWithValue("@NewPhone", globarvar.phone);
                    cmd.Parameters.AddWithValue("@NewPayment", globarvar.payment);
                    cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);

                    int rows = cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("successfully ordered");



                }
                else
                {
                    MessageBox.Show("information is incomplete");
                }


                con = new SqlConnection(myDBConnectingstring);
                con.Open();
                strSQL = "SELECT id FROM order_history WHERE id=(SELECT max(id) FROM order_history) and name = @Name";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Name", globarvar.name);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    globarvar.id = Convert.ToInt32($"{reader["id"]}");


                }


                reader.Close();



                for (int i = 0; i < globarvar.goods.Count; i++)
                {


                    strSQL = "insert into item_list (id, item , price) values (@Newid,@Newitem,@Newprice);";
                    cmd = new SqlCommand(strSQL, con);
                    //MessageBox.Show(globarvar.id.ToString() + globarvar.goods[i].ToString()+globarvar.price[i].ToString());
                    cmd.Parameters.AddWithValue("@Newid", globarvar.id);
                    cmd.Parameters.AddWithValue("@Newitem", globarvar.goods[i]);
                    cmd.Parameters.AddWithValue("@Newprice", globarvar.price[i]);

                    var row = cmd.ExecuteNonQuery();
                }





                
                con.Close();




            }
            else
            {
                MessageBox.Show("plsese log in , or register membership , it is all free");
            }
        }
    }
}
