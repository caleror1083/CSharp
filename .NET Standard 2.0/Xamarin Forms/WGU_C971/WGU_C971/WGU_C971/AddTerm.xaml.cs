/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WGU_C971
	{
		[XamlCompilation(XamlCompilationOptions.Compile)]
		public partial class AddTerm : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				public MainPage _mainPage;

				public AddTerm(MainPage myMainPage)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_mainPage = myMainPage;
					}

				private async void SaveTermBtn(object sender, EventArgs e)
					{
						var newTerm = new Term();
						newTerm.Title = TermTitle.Text;
						newTerm.StartDate = StartDate.Date;
						newTerm.EndDate = EndDate.Date;

						if (newTerm.StartDate < newTerm.EndDate)
							{
								if (Validation.NullCheck(newTerm.Title))
									{
										await _connection.InsertAsync(newTerm);
										_mainPage._termList.Add(newTerm);
										await Navigation.PopModalAsync();
									}
								else
									{
										await DisplayAlert("Error", "Term title cannot be blank", "OK");
									}
							}
						else
							{
								await DisplayAlert("Error", "Make sure Start date is before End date", "OK");
							}
					}
			}
	}