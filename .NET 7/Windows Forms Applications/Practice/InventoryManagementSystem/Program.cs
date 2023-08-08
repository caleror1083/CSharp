// C968 Software I - C# - Robert Calero - Student ID# 000998416
using System.Windows.Forms;

namespace InventoryManagementSystem;

internal static class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainScreen());
    }
}