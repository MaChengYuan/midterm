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
    public partial class classic : Form
    {
        public classic()
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

            pictureBox1.Visible = false;

            btn_submit.Visible = false;
        }

        private void panel(Panel c)
        {
            if(c.Visible == false)
            {
                c.Visible = true;
            }
            else
            {
                c.Visible = false;
            }
        }

        private void listBox_sauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                panel(panel3);
                sauce1.BringToFront();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox_sauce.SelectedIndex > -1)
            {
                panel(panel4);
                salad1.BringToFront();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox_salad.SelectedIndex >-1)
            {
                panel(panel5);
                drink1.BringToFront();
            }
        }

        private void listBox_salad_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_beverage_Click(object sender, EventArgs e)
        {
            if(listBox_beverage.SelectedIndex >-1)
            {
                btn_submit.Visible = true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("successfully added");

            int item = listBox_sauce.SelectedIndex;
            string sauce = listBox_sauce.SelectedItem.ToString();
            string salad = listBox_salad.SelectedItem.ToString();
            string drink = listBox_beverage.SelectedItem.ToString();
            globarvar.goods.Add("single set    "+sauce+"  "+salad+"  "+drink);
            globarvar.price.Add(5);
            globarvar.orderlist.Add("solo set   " + sauce + "  " + salad + "  " + drink + "  " + "$" +  5);


        }
    }
}
