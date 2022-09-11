using System.Windows.Forms;

// Namespaces
namespace Variables
    {
        // Classes
        static class Program
            {
                // Methods(Parameters)
                static void Main()
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
            }
    }