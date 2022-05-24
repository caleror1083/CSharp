/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using Xamarin.Forms;

namespace WGU_C971
	{
		public partial class App : Application
			{
				public App()
					{
						InitializeComponent();
						MainPage = new NavigationPage(new MainPage());
					}

				protected override void OnStart()
					{

					}

				protected override void OnSleep()
					{

					}

				protected override void OnResume()
					{

					}
			}
	}