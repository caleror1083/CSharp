using System.ComponentModel;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

partial class Login
{
  private IContainer components = null;
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
    ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
    LoginBtn = new Button();
    ExitBtn = new Button();
    SuspendLayout();
    // 
    // LoginBtn
    // 
    resources.ApplyResources(LoginBtn, "LoginBtn");
    LoginBtn.Name = "LoginBtn";
    LoginBtn.UseVisualStyleBackColor = true;
    // 
    // ExitBtn
    // 
    resources.ApplyResources(ExitBtn, "ExitBtn");
    ExitBtn.Name = "ExitBtn";
    ExitBtn.UseVisualStyleBackColor = true;
    // 
    // Login
    // 
    resources.ApplyResources(this, "$this");
    AutoScaleMode = AutoScaleMode.Font;
    Controls.Add(ExitBtn);
    Controls.Add(LoginBtn);
    Name = "Login";
    ResumeLayout(false);
  }

  #endregion
}