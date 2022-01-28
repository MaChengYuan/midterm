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
   

    public partial class history : Form
    {
        public static history instance;
        public  ListBox lb1 ;
        

        public history()
        {
            InitializeComponent();
            lb1 = listBox1;
            
            instance = this;

            
        }

        private void history_Load(object sender, EventArgs e)
        {
            
            foreach (string i in globarvar.order_history)
                listBox1.Items.Add(i);

        }

        public static void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
