// Robert Calero
// Decisions - C# - Windows Form

using System;
using System.Windows.Forms;

namespace Decisions
    {
        public partial class Form1 : Form
            {
                public Form1()
                    {
                        InitializeComponent();
                    }

                private void button1_Click(object sender, EventArgs e)
                    {
                        if (textBox1.Text == "Rob")
                            {
                                MessageBox.Show("Sup");
                            }
                        else if (textBox1.Text == "Bob")
                            {
                                MessageBox.Show("yoo");
                            }
                        else
                            {
                                MessageBox.Show("schh");
                            }
                    }
            }
    }