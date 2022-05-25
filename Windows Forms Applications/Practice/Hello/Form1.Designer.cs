namespace Hello
{
    partial class Form1
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
            this._Solve = new System.Windows.Forms.Button();
            this._Number1 = new System.Windows.Forms.TextBox();
            this._Number2 = new System.Windows.Forms.TextBox();
            this._Answer = new System.Windows.Forms.TextBox();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this._Solve.BackColor = System.Drawing.SystemColors.Control;
            this._Solve.Location = new System.Drawing.Point(368, 11);
            this._Solve.Name = "btnSolve";
            this._Solve.Size = new System.Drawing.Size(75, 23);
            this._Solve.TabIndex = 6;
            this._Solve.Text = "Solve!";
            this._Solve.UseVisualStyleBackColor = false;
            this._Solve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtNum1
            // 
            this._Number1.Location = new System.Drawing.Point(12, 12);
            this._Number1.Name = "txtNum1";
            this._Number1.Size = new System.Drawing.Size(100, 20);
            this._Number1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this._Number2.Location = new System.Drawing.Point(137, 12);
            this._Number2.Name = "txtNum2";
            this._Number2.Size = new System.Drawing.Size(100, 20);
            this._Number2.TabIndex = 2;
            // 
            // txtAns
            // 
            this._Answer.Enabled = false;
            this._Answer.Location = new System.Drawing.Point(262, 12);
            this._Answer.Name = "txtAns";
            this._Answer.Size = new System.Drawing.Size(100, 20);
            this._Answer.TabIndex = 3;
            // 
            // label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Location = new System.Drawing.Point(118, 15);
            this._Label1.Name = "label1";
            this._Label1.Size = new System.Drawing.Size(13, 13);
            this._Label1.TabIndex = 4;
            this._Label1.Text = "+";
            // 
            // label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Location = new System.Drawing.Point(243, 15);
            this._Label2.Name = "label2";
            this._Label2.Size = new System.Drawing.Size(13, 13);
            this._Label2.TabIndex = 5;
            this._Label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(457, 51);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._Answer);
            this.Controls.Add(this._Number2);
            this.Controls.Add(this._Number1);
            this.Controls.Add(this._Solve);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _Solve;
        private System.Windows.Forms.TextBox _Number1;
        private System.Windows.Forms.TextBox _Number2;
        private System.Windows.Forms.TextBox _Answer;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.Label _Label2;
    }
}

