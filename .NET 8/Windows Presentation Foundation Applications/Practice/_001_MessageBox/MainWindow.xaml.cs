using System.Windows;

namespace _001_MessageBox;
	
public partial class MainWindow : Window
{
	  public MainWindow()
	  {
		    InitializeComponent();
	  }

    private void Btn1_Click(object sender, RoutedEventArgs e)
	  {
        MessageBox.Show("Hello");  // Displays a message when the button is clicked
	  }
}