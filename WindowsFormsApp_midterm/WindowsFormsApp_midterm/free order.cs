using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_midterm
{
    public partial class original : Form
    {
        public original()
        {
            InitializeComponent();

            listBox_sauce.Items.Add("honey & mustard");
            listBox_sauce.Items.Add("yogurt");
            listBox_sauce.Items.Add("caesar");

            listBox_salad.Items.Add("classic");
            listBox_salad.Items.Add("for vegans");
            listBox_salad.Items.Add("pasta salad");
            listBox_salad.Items.Add("fruit salad");

            listBox_beverage.Items.Add("coke");
            listBox_beverage.Items.Add("sprite");
            listBox_beverage.Items.Add("green tea");
            listBox_beverage.Items.Add("fanta");

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            
        }

        private void original_Load(object sender, EventArgs e)
        {

        }

        private void panel(Panel c)
        {
            if (c.Visible == false)
            {
                c.Visible = true;
            }
            else
            {
                c.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sauce1.BringToFront();
            panel(panel3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salad1.BringToFront();
            panel(panel4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drink1.BringToFront();
            panel(panel5);
        }

        private void listBox_sauce_DoubleClick(object sender, EventArgs e)
        {
            int item = listBox_sauce.SelectedIndex;
            string items = listBox_sauce.SelectedItem.ToString();
            globarvar.goods.Add(items);
            globarvar.price.Add(1);
            globarvar.orderlist.Add(items + "   " + "$" + 1);
        }

       

        private void listBox_salad_DoubleClick_1(object sender, EventArgs e)
        {
            int item = listBox_salad.SelectedIndex;
            string items = listBox_salad.SelectedItem.ToString();
            globarvar.goods.Add(items);
            globarvar.price.Add(4);
            globarvar.orderlist.Add(items + "   " + "$" + 4);
        }

        private void listBox_beverage_DoubleClick(object sender, EventArgs e)
        {
            int item = listBox_salad.SelectedIndex;
            string items = listBox_beverage.SelectedItem.ToString();
            globarvar.goods.Add(items);
            globarvar.price.Add(1);
            globarvar.orderlist.Add(items + "   " + "$" + 1);
        }
    }
}
