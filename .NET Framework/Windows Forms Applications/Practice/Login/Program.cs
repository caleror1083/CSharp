// Robert Calero
// Login Form - C# - Windows Form Application .NET Framework

using System.Windows.Forms;

namespace Login
    {
        static class Program
            {
                static void Main()
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new LoginForm());
                    }
            }
    }