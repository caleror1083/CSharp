using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

internal static class Program
{
  internal static void Main()
  {
    ApplicationConfiguration.Initialize();
    Application.Run(new Login());
  }
}