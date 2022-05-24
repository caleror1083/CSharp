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
		public partial class AddAssessment : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Course _course;

				public AddAssessment(Course myCourse)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_course = myCourse;
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Assessment>();
						var myAssessmentsList = await _connection.QueryAsync<Assessment>($"SELECT AssessmentType FROM Assessments WHERE Course = '{_course.ID}'");
						base.OnAppearing();
					}

				private async void SaveAssessmentBtn(object sender, EventArgs e)
					{
						Assessment newAssessment = new Assessment();
						newAssessment.AssessmentName = AssessmentName.Text;
						newAssessment.StartDate = StartDate.Date;
						newAssessment.EndDate = EndDate.Date;
						newAssessment.Course = _course.ID;
						newAssessment.AssessmentType = (string)AssessmentType.SelectedItem;
						await _connection.InsertAsync(newAssessment);
						await Navigation.PopModalAsync();
					}
			}
	}