// Robert Calero
// MessageBox Button - C# - Windows Form Application .NET Framework

using System;
using System.Windows.Forms;

namespace Hello
    {
        public partial class Form1 : Form
            {
                public Form1()
                    {
                        InitializeComponent();
                    }

                private void btnSolve_Click(object sender, EventArgs e)
                    {
                        txtAns.Text = Convert.ToString(Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text));
                    }
            }
    }