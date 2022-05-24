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
		public partial class EditCourse : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Course _currentCourse;

				public EditCourse(Course currentCourse)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_currentCourse = currentCourse;
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Course>();

						CourseName.Text = _currentCourse.CourseName;
						CourseStatus.SelectedItem = _currentCourse.CourseStatus;
						StartDate.Date = _currentCourse.StartDate;
						EndDate.Date = _currentCourse.EndDate;
						InstructorName.Text = _currentCourse.InstructorName;
						InstructorPhone.Text = _currentCourse.InstructorPhone;
						InstructorEmail.Text = _currentCourse.InstructorEmail;
						Notes.Text = _currentCourse.Notes;
						base.OnAppearing();
					}

				private async void SaveBtn(object sender, EventArgs e)
					{
						_currentCourse.CourseName = CourseName.Text;
						_currentCourse.StartDate = StartDate.Date;
						_currentCourse.EndDate = EndDate.Date;
						_currentCourse.CourseStatus = (string)CourseStatus.SelectedItem;
						_currentCourse.InstructorName = InstructorName.Text;
						_currentCourse.InstructorPhone = InstructorPhone.Text;
						_currentCourse.InstructorEmail = InstructorEmail.Text;
						_currentCourse.Notes = Notes.Text;
						_currentCourse.Notifications = Notifications.On == true ? 1 : 0;


						if (Validation.NullCheck(InstructorName.Text) && Validation.NullCheck(InstructorPhone.Text) && Validation.NullCheck(CourseName.Text))
							{
								if (Validation.EmailCheck(InstructorEmail.Text))
									{
										if(_currentCourse.StartDate < _currentCourse.EndDate)
											{
												await _connection.UpdateAsync(_currentCourse);
												await Navigation.PopModalAsync();
											}
										else
											{
												await DisplayAlert("Alert", "Start date has to be before End date", "Ok");
											}
									}
								else
									{
										await DisplayAlert("Alert", "Enter a valid email", "Ok");
									}
							}
						else
							{
								await DisplayAlert("Alert", "Fields cannot be blank", "Ok");
							}
					}
			}
	}