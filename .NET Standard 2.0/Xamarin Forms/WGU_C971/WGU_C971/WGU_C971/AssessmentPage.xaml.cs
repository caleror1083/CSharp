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
		public partial class AssessmentPage : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Assessment _assessment;

				public AssessmentPage(Assessment myAssessment)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_assessment = myAssessment;
					}

				protected override void OnAppearing()
					{
						Title = _assessment.AssessmentType;
						AssessmentName.Text = _assessment.AssessmentName;
						StartDate.Text = _assessment.StartDate.ToString("MM/dd/yy");
						EndDate.Text = _assessment.EndDate.ToString("MM/dd/yy");
						Notifications.Text = _assessment.Notifications == 1 ? "Yes" : "No";
						base.OnAppearing();
					}

				private async void EditAssessmentBtn(object sender, EventArgs e)
					{
						await Navigation.PushModalAsync(new EditAssessment(_assessment));
					}

				private async void DeleteAssessmentBtn(object sender, EventArgs e)
					{
						var answer = await DisplayAlert("Caution", "Do you want to delete this assessment?", "Yes", "No");
						
						if (answer)
							{
								await _connection.DeleteAsync(_assessment);
								await Navigation.PopAsync();
							}
					}
			}
	}