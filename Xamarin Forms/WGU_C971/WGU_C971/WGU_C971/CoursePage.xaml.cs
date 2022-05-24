/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using SQLite;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WGU_C971
    {
		[XamlCompilation(XamlCompilationOptions.Compile)]
		public partial class CoursePage : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Course _currentCourse;

				public CoursePage(Course myCourse)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_currentCourse = myCourse;
					}

				protected override void OnAppearing()
					{
						Title = _currentCourse.CourseName;
						CourseStatus.Text = _currentCourse.CourseStatus;
						StartDate.Text = _currentCourse.StartDate.ToString("MM/dd/yy");
						EndDate.Text = _currentCourse.EndDate.ToString("MM/dd/yy");
						InstructorName.Text = _currentCourse.InstructorName;
						InstructorEmail.Text = _currentCourse.InstructorEmail;
						InstructorPhone.Text = _currentCourse.InstructorPhone;
						Notes.Text = _currentCourse.Notes;
						Notifications.Text = _currentCourse.Notifications == 1 ? "Yes" : "No";
						base.OnAppearing();
					}

				private async void ShareBtn_Clicked(object sender, EventArgs e)
					{
						await Share.RequestAsync(new ShareTextRequest
							{
								Text = Notes.Text,
								Title = "Share your notes on this course"
							});
					}

				private async void EditCourseBtn(object sender, EventArgs e)
					{
						await Navigation.PushModalAsync(new EditCourse(_currentCourse));
					}

				private async void DeleteCourseBtn(object sender, EventArgs e)
					{
						var answer = await DisplayAlert("Caution", "Do you want to delete this course?", "Yes", "No");

						if (answer)
							{
								await _connection.DeleteAsync(_currentCourse);
								await Navigation.PopAsync();
							}
					}

				async void AssessmentsBtn(object sender, EventArgs e)
					{
						await Navigation.PushAsync(new AssessmentsPage(_currentCourse));
					}
			}
	}