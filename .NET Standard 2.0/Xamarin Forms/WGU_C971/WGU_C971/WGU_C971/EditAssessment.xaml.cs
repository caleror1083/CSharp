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
		public partial class EditAssessment : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Assessment _assessment;

				public EditAssessment(Assessment myAssessment)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_assessment = myAssessment;
					}

                protected override async void OnAppearing()
                    {
                        await _connection.CreateTableAsync<Assessment>();
                        AssessmentName.Text = _assessment.AssessmentName;
                        StartDate.Date = _assessment.StartDate;
                        EndDate.Date = _assessment.EndDate;
                        Notifications.On = _assessment.Notifications == 1 ? true : false;
                        base.OnAppearing();
                    }

                private async void SaveAssessmentBtn(object sender, EventArgs e)
                    {
                        _assessment.AssessmentName = AssessmentName.Text;
                        _assessment.StartDate = StartDate.Date;
                        _assessment.EndDate = EndDate.Date;
                        _assessment.Notifications = Notifications.On == true ? 1 :0;
                        await _connection.UpdateAsync(_assessment);
                        await Navigation.PopModalAsync();
                    }
			}
	}