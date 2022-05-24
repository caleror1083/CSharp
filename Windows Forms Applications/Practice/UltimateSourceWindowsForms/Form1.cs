using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateSourceWindowsForms
	{
		public partial class Form1 : Form
			{
				static String fieldName1, fieldName2;

				public Form1()
					{
						InitializeComponent();
					}

				public static void SetPlayerNames(String name1, String name2)
					{
						player1 = name1;
						player2 = name2;
					}

				private void Form1_Load(object sender, EventArgs e)
					{
						DifferentFormName variableName = new DifferentFormName();
						variableName.ShowDialog();
						label1.Text = fieldName1;	// static String player1
						label2.Text = fieldName2;	// static String player2
					}

				// Form 2 code
				private void Player2Txt_KeyPress(object sender, KeyPressEventArgs e)
					{
						if (e.ToString() == "\r")
							{
								PlayBtn.PerformClick();
							}
					}

				private void PlayBtn_Click(object sender, EventArgs e)
					{
						GameBoard.SetPlayerNames(Player1Txt.Text, Player2Txt.Text);
						this.Close();
					}
			}
	}