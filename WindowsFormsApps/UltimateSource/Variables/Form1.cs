using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Rob";
            MessageBox.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 5;
            MessageBox.Show(num.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool redHair = false;
            MessageBox.Show(redHair.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object myObj = true; // can assign string, number or bool
            MessageBox.Show(myObj.ToString());
        }
    }
}