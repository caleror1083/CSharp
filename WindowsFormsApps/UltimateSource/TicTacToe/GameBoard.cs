// Robert Calero
// Tic Tac Toe - C# - Windows Form Application .NET Framework

using System;
using System.Windows.Forms;

namespace TicTacToe
	{
		public partial class GameBoard : Form
			{
				// True = X turn
				// False = O turn
				bool turn = true;      // Variable declaration and initialization of type boolean
				bool CPU = false;	   // By default start the game in 2-Player mode
				int turn_count = 0;    // Variable declaration and initialization of type integer

				public GameBoard()
					{
						InitializeComponent();
					}

				private void AboutMenuItem_Click(object sender, System.EventArgs e)
					{
						MessageBox.Show("Application by Robert Calero", "About");
					}

				private void ExitMenuItem_Click(object sender, System.EventArgs e)
					{
						Application.Exit();
					}

				private void Button_click(object sender, System.EventArgs e)
					{
						if ((Player1Txt.Text == "Player 1") || (Player2Txt.Text == "Player 2"))
							{
								MessageBox.Show("You must specify the players' names before you can start!");
							}
						else
							{
								Button b = (Button)sender;  // casts the sender object as a button
								if (turn)   // when turn = true
									{
										b.Text = "X";
									}
								else       // when turn = false
									{
										b.Text = "O";
									}
								turn = !turn;
								b.Enabled = false;  // disabled the button enabled property when user clicks a button
								turn_count++;
								CheckForWinner();
							}

						if ((!turn) && (CPU))		// Checks to see if you are playing against the computer and if it's O's turn
							{
								CPUMakeMove();
							}
					}

				private void CPUMakeMove()
					{
						// priority 1:  get tic tac toe
						// priority 2:  block x tic tac toe
						// priority 3:  go for corner space
						// priority 4:  pick open space
						Button move = null;
 
						// look for tic tac toe opportunities
						move = LookForWinOrBlock("O");		// look for win
            
						if (move == null)
							{
								move = LookForWinOrBlock("X");   // look for block
                
								if (move == null)
									{
										move = LookForCorner();
                    
										if (move == null)
											{
												move = LookForOpenSpace();
											}	// end if
									}	// end if
							} // end if
						move.PerformClick();
					}


				private Button LookForOpenSpace()
					{
						Console.WriteLine("Looking for open space");
						Button b = null;
						foreach (Control c in Controls)
							{
								b = c as Button;
								if (b != null)
									{
										if (b.Text == "")
											return b;
									}//end if
							}//end if
							return null;
					}


				private Button LookForCorner()
					{
						Console.WriteLine("Looking for corner");
						if (A1.Text == "O")
							{
								if (A3.Text == "")
									return A3;
								if (C3.Text == "")
									return C3;
								if (C1.Text == "")
									return C1;
							}
 
						if (A3.Text == "O")
							{
								if (A1.Text == "")
									return A1;
								if (C3.Text == "")
									return C3;
								if (C1.Text == "")
									return C1;
							}
 
						if (C3.Text == "O")
							{
								if (A1.Text == "")
									return A3;
								if (A3.Text == "")
									return A3;
								if (C1.Text == "")
									return C1;
							}
 
						if (C1.Text == "O")
							{
								if (A1.Text == "")
									return A3;
								if (A3.Text == "")
									return A3;
								if (C3.Text == "")
									return C3;
							}
           
						if (A1.Text == "")
							return A1;
						if (A3.Text == "")
							return A3;
						if (C1.Text == "")
							return C1;
						if (C3.Text == "")
							return C3;
 
						return null;
					}

				private Button LookForWinOrBlock(string mark)
					{
						Console.WriteLine("Looking for win or block:  " + mark);
            
						// Horizontal tests
						if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
							{
								return A3;
							}
						if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
							{
								return A1;
							}
						if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
							{
								return A2;
							}
						if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
							{
								return B3;
							}
						if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
							{
								return B1;
							}
						if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
							{
								return B2;
							} 
						if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
							{
								return C3;
							}
						if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
							{
								return C1;
							}
						if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
							{
								return C2;
							}

						// Vertical tests
						if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
							{
								return C1;
							}
						if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
							{
								return A1;
							}
						if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
							{
								return B1;
							}
						if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
							{
								return C2;
							}
						if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
							{
								return A2;
							}
						if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
							{
								return B2;
							}
						if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
							{
								return C3;
							}
						if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
							{
								return A3;
							}
						if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
							{
								return B3;
							}

						// Diagonal tests
						if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
							{
								return C3;
							}
						if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
							{
								return A1;
							}
						if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
							{
								return B2;
							}
						if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
							{
								return C1;
							}
						if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
							{
								return A3;
							}
						if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
							{
								return B2;
							} 
						return null;	// Computer could not find an opportunity for Tic-Tac-Toe
					}

				private void CheckForWinner()
					{
						bool winner = false;
						
						// horizontal checks
						if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
							{
								winner = true;
							}
						else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
							{
								winner = true;
							}
						else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
							{
								winner = true;
							}

						// vertical checks
						else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
							{
								winner = true;
							}
						else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
							{
								winner = true;
							}
						else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
							{
								winner = true;
							}

						// diagonal checks
						else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
							{
								winner = true;
							}
						else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
							{
								winner = true;
							}

						if (winner)
							{
								DisableButtons();
								string champion;

								if (turn)
									{
										champion = Player2Txt.Text;
										O_Win_Count.Text = (Int32.Parse(O_Win_Count.Text) + 1).ToString();
									}
								else
									{
										champion = Player1Txt.Text;
										X_Win_Count.Text = (Int32.Parse(X_Win_Count.Text) + 1).ToString();
									}
								MessageBox.Show(champion + " wins!", "Final");
								NewGameMenuItem.PerformClick();
							}   // end winner
						else
							{
								if (turn_count == 9)
									{
										Draw_Count.Text = (Int32.Parse(Draw_Count.Text) + 1).ToString();
										MessageBox.Show("Draw", "Final");
										NewGameMenuItem.PerformClick();
									}
							}
					}   // end checkForWinner

				private void DisableButtons()
					{
						try
							{
								foreach (Control c in Controls)
									{
										Button b = (Button)c;
										b.Enabled = false;
									}   // end foreach
							}   // end try
						catch { }
					}

				private void NewGameMenuItem_Click(object sender, System.EventArgs e)
					{
						turn = true;
						turn_count = 0;

						foreach (Control myControls in Controls)    // foreach loop checking the controls in a form
							{
								try
									{
									    Button myButton = (Button)myControls;
										myButton.Text = "";
										myButton.Enabled = true;
									}	// end try
								catch { }
							}   // end foreach
					}

				private void Button_enter(object sender, System.EventArgs e)
					{
						Button b = (Button)sender;	// creates a reference to the button control
						if (b.Enabled)
							{
								if (turn)   // when turn = true
									{
										b.Text = "X";
									}
								else       // when turn = false
									{
										b.Text = "O";
									}
							}	// end if
					}

				private void Button_leave(object sender, System.EventArgs e)
					{
						Button b = (Button)sender;	// creates a reference to the button control
						if (b.Enabled)
							{
								b.Text = "";
							}	// end if
					}
	
				private void ResetCountMenuItem_Click(object sender, EventArgs e)
					{
						X_Win_Count.Text = "0";
						Draw_Count.Text = "0";
						O_Win_Count.Text = "0";
					}

				private void GameBoard_Load(object sender, EventArgs e)
					{
						setPlayerDefaultsToolStripMenuItem.PerformClick();		// When the form launches, Set Player Defaults are auto enabled
					}

				private void Player2Txt_TextChanged(object sender, EventArgs e)		// Depending on the value of the textbox determines wheather you play against the CPU
					{
						if (Player2Txt.Text.ToUpper() == "COMPUTER")		// Matches the characters entered wheather in all lowercase or Uppercase
							{
								CPU = true;
							}
						else
							{
								CPU = false;
							}
					}
	
				private void SetPlayerDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
					{
						Player1Txt.Text = "Rob";
						Player2Txt.Text = "Computer";
					}
			}
	}