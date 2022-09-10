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

                private void Solve_Click(object sender, EventArgs e)
                    {
                        _Answer.Text = Convert.ToString(int.Parse(_Number1.Text) + int.Parse(_Number2.Text));
                    }
            }
    }