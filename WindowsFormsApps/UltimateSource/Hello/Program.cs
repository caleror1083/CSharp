// Robert Calero
// MessageBox Button - C# - Windows Form Application .NET Framework

using System.Windows.Forms;

namespace Hello
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