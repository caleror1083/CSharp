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
		public partial class AddCourse : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private Term _currentTerm;

				public AddCourse(Term currentTerm)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_currentTerm = currentTerm;
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Course>();
						base.OnAppearing();
					}

				private async void SaveCourseBtn(object sender, EventArgs e)
					{
						var newCourse = new Course();
						newCourse.CourseName = CourseName.Text;
						newCourse.StartDate = StartDate.Date;
						newCourse.EndDate = EndDate.Date;
						newCourse.CourseStatus = (string)CourseStatus.SelectedItem;
						newCourse.InstructorName = InstructorName.Text;
						newCourse.InstructorPhone = InstructorPhone.Text;
						newCourse.InstructorEmail = InstructorEmail.Text;
						newCourse.Notes = Notes.Text;
						newCourse.Notifications = Notifications.On == true ? 1 : 0;
						newCourse.Term = _currentTerm.ID;

						if (Validation.NullCheck(InstructorName.Text) && Validation.NullCheck(InstructorPhone.Text) && Validation.NullCheck(CourseName.Text))
							{
								if (Validation.EmailCheck(InstructorEmail.Text))
									{
										if (newCourse.StartDate < newCourse.EndDate)
											{
												await _connection.InsertAsync(newCourse);
												await Navigation.PopModalAsync();
											}
										else
											{
												await DisplayAlert("Caution", "The start date must be before the end date", "Ok");
											}
									}
								else
									{
										await DisplayAlert("Caution", "The email must be valid before sumbitting", "Ok");
									}
							}
						else
							{
								await DisplayAlert("Caution", "Fields cannot be black", "Ok");
							}
					}
			}
	}