using System.Windows.Forms;

namespace EmailSender
    {
        static class Program
            {
                static void Main()
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
            }
    }