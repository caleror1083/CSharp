using DentalOfficeSchedulingApp.Models;
using DentalOfficeSchedulingApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

public partial class Login : Form
{
    private string _credentialsError = "The username and password did not match.";
    private string _applicationExit = "Are you sure you wish to exit the application?";

    public Login()
    {
        InitializeComponent();
        CheckLanguage(CultureInfo.CurrentUICulture.LCID);
    }

    private void CheckLanguage(int lcid)
    {
        if (lcid == 1034)
        {
            Text = "Acceso";
            UserNameLbl.Text = "Nombre de usuario";
            PasswordLbl.Text = "Contraseña";
            LoginBtn.Text = "Iniciar sesión";
            ExitBtn.Text = "Salida";
            _credentialsError = "El nombre de usuario y la contraseña no coinciden.";
            _applicationExit = "¿Quieres salir de la aplicación?";
        }
    }

    private void LoginBtn_Click(object? sender, EventArgs e)
    {
        using var context = new SchedulingContext();
        var user = context.Users.AsNoTracking().FirstOrDefault(u => u.UserName == UserNameTxt.Text && u.Password == PasswordTxt.Text && u.Active == 1);

        if (user is null)
        {
            MessageBox.Show(_credentialsError);
            return;
        }
          
        CurrentUser.Set(user.UserId, user.UserName);
        Log.Login(CurrentUser.UserName);
        Hide();
        using var scheduling = new Scheduling();
        scheduling.ShowDialog();
        Close();
    }

    private void ExitBtn_Click(object? sender, EventArgs e)
    {
        var confirmation = MessageBox.Show(_applicationExit, Text, MessageBoxButtons.YesNo);

        if (confirmation == DialogResult.Yes)
        {
            Close();
        }
    }
}