namespace SoftwareCompanyScheduling;

partial class Login
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
        UsernameLbl = new Label();
        PasswordLbl = new Label();
        UsernameTxt = new TextBox();
        PasswordTxt = new TextBox();
        LoginBtn = new Button();
        ExitBtn = new Button();
        LoginErrorLbl = new Label();
        SuspendLayout();
        // 
        // UsernameLbl
        // 
        UsernameLbl.AutoSize = true;
        UsernameLbl.Location = new Point(80, 59);
        UsernameLbl.Name = "UsernameLbl";
        UsernameLbl.Size = new Size(55, 13);
        UsernameLbl.TabIndex = 2;
        UsernameLbl.Text = "Username";
        // 
        // PasswordLbl
        // 
        PasswordLbl.AutoSize = true;
        PasswordLbl.Location = new Point(83, 108);
        PasswordLbl.Name = "PasswordLbl";
        PasswordLbl.Size = new Size(53, 13);
        PasswordLbl.TabIndex = 3;
        PasswordLbl.Text = "Password";
        // 
        // UsernameTxt
        // 
        UsernameTxt.Location = new Point(178, 59);
        UsernameTxt.Name = "UsernameTxt";
        UsernameTxt.Size = new Size(134, 20);
        UsernameTxt.TabIndex = 0;
        // 
        // PasswordTxt
        // 
        PasswordTxt.Location = new Point(178, 100);
        PasswordTxt.Name = "PasswordTxt";
        PasswordTxt.Size = new Size(134, 20);
        PasswordTxt.TabIndex = 1;
        // 
        // LoginBtn
        // 
        LoginBtn.Location = new Point(86, 178);
        LoginBtn.Name = "LoginBtn";
        LoginBtn.Size = new Size(75, 23);
        LoginBtn.TabIndex = 4;
        LoginBtn.Text = "Login";
        LoginBtn.UseVisualStyleBackColor = true;
        LoginBtn.Click += LoginBtn_Click;
        // 
        // ExitBtn
        // 
        ExitBtn.Location = new Point(237, 178);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new Size(75, 23);
        ExitBtn.TabIndex = 5;
        ExitBtn.Text = "Exit";
        ExitBtn.UseVisualStyleBackColor = true;
        ExitBtn.Click += ExitBtn_Click;
        // 
        // LoginErrorLbl
        // 
        LoginErrorLbl.AutoSize = true;
        LoginErrorLbl.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        LoginErrorLbl.ForeColor = SystemColors.HotTrack;
        LoginErrorLbl.Location = new Point(50, 147);
        LoginErrorLbl.Name = "LoginErrorLbl";
        LoginErrorLbl.Size = new Size(0, 17);
        LoginErrorLbl.TabIndex = 6;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(428, 226);
        Controls.Add(LoginErrorLbl);
        Controls.Add(ExitBtn);
        Controls.Add(LoginBtn);
        Controls.Add(PasswordTxt);
        Controls.Add(UsernameTxt);
        Controls.Add(PasswordLbl);
        Controls.Add(UsernameLbl);
        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "Login";
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label UsernameLbl;
    private Label PasswordLbl;
    private TextBox UsernameTxt;
    private TextBox PasswordTxt;
    private Button LoginBtn;
    private Button ExitBtn;
    private Label LoginErrorLbl;
}