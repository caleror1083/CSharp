using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

partial class Login
{
    private IContainer components = null;
    private Label UserNameLbl;
    private TextBox UserNameTxt;
    private Label PasswordLbl;
    private TextBox PasswordTxt;
    private Button LoginBtn;
    private Button ExitBtn;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        UserNameLbl = new Label();
        UserNameTxt = new TextBox();
        PasswordLbl = new Label();
        PasswordTxt = new TextBox();
        LoginBtn = new Button();
        ExitBtn = new Button();

        SuspendLayout();

        // UserNameLbl
        UserNameLbl.AutoSize = true;
        UserNameLbl.Location = new Point(30, 30);
        UserNameLbl.Name = "UserNameLbl";
        UserNameLbl.Size = new Size(65, 15);
        UserNameLbl.Text = "Username";

        // UserNameTxt
        UserNameTxt.Location = new Point(120, 27);
        UserNameTxt.Name = "UserNameTxt";
        UserNameTxt.Size = new Size(180, 23);

        // PasswordLbl
        PasswordLbl.AutoSize = true;
        PasswordLbl.Location = new Point(30, 70);
        PasswordLbl.Name = "PasswordLbl";
        PasswordLbl.Size = new Size(57, 15);
        PasswordLbl.Text = "Password";

        // PasswordTxt
        PasswordTxt.Location = new Point(120, 67);
        PasswordTxt.Name = "PasswordTxt";
        PasswordTxt.Size = new Size(180, 23);
        PasswordTxt.UseSystemPasswordChar = true;

        // LoginBtn
        LoginBtn.Location = new Point(120, 115);
        LoginBtn.Name = "LoginBtn";
        LoginBtn.Size = new Size(80, 30);
        LoginBtn.Text = "Login";
        LoginBtn.UseVisualStyleBackColor = true;
        LoginBtn.Click += LoginBtn_Click;

        // ExitBtn
        ExitBtn.Location = new Point(220, 115);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new Size(80, 30);
        ExitBtn.Text = "Exit";
        ExitBtn.UseVisualStyleBackColor = true;
        ExitBtn.Click += ExitBtn_Click;

        // Login
        AcceptButton = LoginBtn;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(350, 180);

        Controls.Add(UserNameLbl);
        Controls.Add(UserNameTxt);
        Controls.Add(PasswordLbl);
        Controls.Add(PasswordTxt);
        Controls.Add(LoginBtn);
        Controls.Add(ExitBtn);

        Name = "Login";
        Text = "Login";

        ResumeLayout(false);
        PerformLayout();
    }
    #endregion
}