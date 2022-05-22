// Robert Calero
// Email Sender - Visual C# - Windows Form Application

using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(!txtEmail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You need to provide a Google email.");
                    return;
                }
                btnSend.Enabled = false;
                MailMessage message = new MailMessage();    // initializes the MailMessage

                message.From = new MailAddress(txtEmail.Text); // initializes the MailAddress
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;

                foreach (string s in txtRecipiant.Text.Split(';'))
                {
                    message.To.Add(s);
                }

                SmtpClient client = new SmtpClient();

                client.Credentials = new NetworkCredential(txtEmail.Text, txtPass.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }
            catch
            {
                MessageBox.Show("There was an error sending the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }
    }
}