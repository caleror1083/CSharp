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
		public partial class EditTerm : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Term _currentTerm;

				public EditTerm(Term currentTerm)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_currentTerm = currentTerm;
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Term>();
						TermTitle.Text = _currentTerm.Title;
						StartDate.Date = _currentTerm.StartDate;
						base.OnAppearing();
					}

				private async void SaveBtn(object sender, EventArgs e)
					{
						_currentTerm.Title = TermTitle.Text;
						_currentTerm.StartDate = StartDate.Date;
						_currentTerm.EndDate = EndDate.Date;

						if (_currentTerm.StartDate < _currentTerm.EndDate)
							{
								if (Validation.NullCheck(_currentTerm.Title))
									{
										await _connection.UpdateAsync(_currentTerm);
										await Navigation.PopModalAsync();
									}
								else
									{
										await DisplayAlert("Alert", "Term Title cannot be blank", "OK");
									}
							}
						else
							{
								await DisplayAlert("Alert", "Start date has to be before End date", "OK");
							}
					}
			}
	}