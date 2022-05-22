namespace TicTacToe
{
	partial class GameBoard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setPlayerDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ResetCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.Draw_Label = new System.Windows.Forms.Label();
			this.X_Win_Count = new System.Windows.Forms.Label();
			this.Draw_Count = new System.Windows.Forms.Label();
			this.O_Win_Count = new System.Windows.Forms.Label();
			this.Player1Txt = new System.Windows.Forms.TextBox();
			this.Player2Txt = new System.Windows.Forms.TextBox();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuStrip1
			// 
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(258, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.setPlayerDefaultsToolStripMenuItem,
            this.ResetCountToolStripMenuItem,
            this.ExitMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// NewGameMenuItem
			// 
			this.NewGameMenuItem.Name = "NewGameMenuItem";
			this.NewGameMenuItem.Size = new System.Drawing.Size(180, 22);
			this.NewGameMenuItem.Text = "New Game";
			this.NewGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
			// 
			// setPlayerDefaultsToolStripMenuItem
			// 
			this.setPlayerDefaultsToolStripMenuItem.Name = "setPlayerDefaultsToolStripMenuItem";
			this.setPlayerDefaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.setPlayerDefaultsToolStripMenuItem.Text = "Set Player Defaults";
			this.setPlayerDefaultsToolStripMenuItem.Click += new System.EventHandler(this.SetPlayerDefaultsToolStripMenuItem_Click);
			// 
			// ResetCountToolStripMenuItem
			// 
			this.ResetCountToolStripMenuItem.Name = "ResetCountToolStripMenuItem";
			this.ResetCountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ResetCountToolStripMenuItem.Text = "Reset WIn Count";
			this.ResetCountToolStripMenuItem.Click += new System.EventHandler(this.ResetCountMenuItem_Click);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ExitMenuItem.Text = "Exit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
			this.AboutMenuItem.Text = "About";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
			// 
			// A1
			// 
			this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.Location = new System.Drawing.Point(12, 27);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(75, 75);
			this.A1.TabIndex = 1;
			this.A1.TabStop = false;
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.Button_click);
			this.A1.MouseEnter += new System.EventHandler(this.Button_enter);
			this.A1.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// A2
			// 
			this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.Location = new System.Drawing.Point(93, 27);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(75, 75);
			this.A2.TabIndex = 2;
			this.A2.TabStop = false;
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.Button_click);
			this.A2.MouseEnter += new System.EventHandler(this.Button_enter);
			this.A2.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// A3
			// 
			this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.Location = new System.Drawing.Point(174, 27);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(75, 75);
			this.A3.TabIndex = 3;
			this.A3.TabStop = false;
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.Button_click);
			this.A3.MouseEnter += new System.EventHandler(this.Button_enter);
			this.A3.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// B1
			// 
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Location = new System.Drawing.Point(12, 108);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(75, 75);
			this.B1.TabIndex = 4;
			this.B1.TabStop = false;
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.Button_click);
			this.B1.MouseEnter += new System.EventHandler(this.Button_enter);
			this.B1.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// B2
			// 
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Location = new System.Drawing.Point(93, 108);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(75, 75);
			this.B2.TabIndex = 5;
			this.B2.TabStop = false;
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.Button_click);
			this.B2.MouseEnter += new System.EventHandler(this.Button_enter);
			this.B2.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// B3
			// 
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Location = new System.Drawing.Point(174, 108);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(75, 75);
			this.B3.TabIndex = 6;
			this.B3.TabStop = false;
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.Button_click);
			this.B3.MouseEnter += new System.EventHandler(this.Button_enter);
			this.B3.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// C1
			// 
			this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.Location = new System.Drawing.Point(12, 189);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(75, 75);
			this.C1.TabIndex = 7;
			this.C1.TabStop = false;
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.Button_click);
			this.C1.MouseEnter += new System.EventHandler(this.Button_enter);
			this.C1.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// C2
			// 
			this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.Location = new System.Drawing.Point(93, 189);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(75, 75);
			this.C2.TabIndex = 8;
			this.C2.TabStop = false;
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.Button_click);
			this.C2.MouseEnter += new System.EventHandler(this.Button_enter);
			this.C2.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// C3
			// 
			this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.Location = new System.Drawing.Point(174, 189);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(75, 75);
			this.C3.TabIndex = 9;
			this.C3.TabStop = false;
			this.C3.UseVisualStyleBackColor = true;
			this.C3.Click += new System.EventHandler(this.Button_click);
			this.C3.MouseEnter += new System.EventHandler(this.Button_enter);
			this.C3.MouseLeave += new System.EventHandler(this.Button_leave);
			// 
			// Draw_Label
			// 
			this.Draw_Label.AutoSize = true;
			this.Draw_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Draw_Label.Location = new System.Drawing.Point(109, 273);
			this.Draw_Label.Name = "Draw_Label";
			this.Draw_Label.Size = new System.Drawing.Size(42, 13);
			this.Draw_Label.TabIndex = 11;
			this.Draw_Label.Text = "Draws";
			// 
			// X_Win_Count
			// 
			this.X_Win_Count.AutoSize = true;
			this.X_Win_Count.Location = new System.Drawing.Point(44, 294);
			this.X_Win_Count.Name = "X_Win_Count";
			this.X_Win_Count.Size = new System.Drawing.Size(13, 13);
			this.X_Win_Count.TabIndex = 13;
			this.X_Win_Count.Text = "0";
			// 
			// Draw_Count
			// 
			this.Draw_Count.AutoSize = true;
			this.Draw_Count.Location = new System.Drawing.Point(123, 294);
			this.Draw_Count.Name = "Draw_Count";
			this.Draw_Count.Size = new System.Drawing.Size(13, 13);
			this.Draw_Count.TabIndex = 14;
			this.Draw_Count.Text = "0";
			// 
			// O_Win_Count
			// 
			this.O_Win_Count.AutoSize = true;
			this.O_Win_Count.Location = new System.Drawing.Point(202, 294);
			this.O_Win_Count.Name = "O_Win_Count";
			this.O_Win_Count.Size = new System.Drawing.Size(13, 13);
			this.O_Win_Count.TabIndex = 15;
			this.O_Win_Count.Text = "0";
			// 
			// Player1Txt
			// 
			this.Player1Txt.Location = new System.Drawing.Point(13, 270);
			this.Player1Txt.Name = "Player1Txt";
			this.Player1Txt.Size = new System.Drawing.Size(75, 20);
			this.Player1Txt.TabIndex = 16;
			this.Player1Txt.TabStop = false;
			this.Player1Txt.Text = "Player 1";
			this.Player1Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Player2Txt
			// 
			this.Player2Txt.Location = new System.Drawing.Point(174, 269);
			this.Player2Txt.Name = "Player2Txt";
			this.Player2Txt.Size = new System.Drawing.Size(75, 20);
			this.Player2Txt.TabIndex = 17;
			this.Player2Txt.TabStop = false;
			this.Player2Txt.Text = "Player 2";
			this.Player2Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Player2Txt.TextChanged += new System.EventHandler(this.Player2Txt_TextChanged);
			// 
			// GameBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 319);
			this.Controls.Add(this.Player2Txt);
			this.Controls.Add(this.Player1Txt);
			this.Controls.Add(this.O_Win_Count);
			this.Controls.Add(this.Draw_Count);
			this.Controls.Add(this.X_Win_Count);
			this.Controls.Add(this.Draw_Label);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.MenuStrip1);
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.Name = "GameBoard";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.GameBoard_Load);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.Label Draw_Label;
		private System.Windows.Forms.Label X_Win_Count;
		private System.Windows.Forms.Label Draw_Count;
		private System.Windows.Forms.Label O_Win_Count;
		private System.Windows.Forms.ToolStripMenuItem ResetCountToolStripMenuItem;
		private System.Windows.Forms.TextBox Player1Txt;
		private System.Windows.Forms.TextBox Player2Txt;
		private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem;
	}
}

