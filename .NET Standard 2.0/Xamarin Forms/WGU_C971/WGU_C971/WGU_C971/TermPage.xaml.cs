/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WGU_C971
	{
		[XamlCompilation(XamlCompilationOptions.Compile)]
		public partial class TermPage : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private ObservableCollection<Course> _courseList;
				private Term _currentTerm;

				public TermPage(Term myTerm)
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						_currentTerm = myTerm;
						Title = myTerm.Title;
						CourseLV.ItemTapped += new EventHandler<ItemTappedEventArgs>(Course_Tapped);
					}

				protected override async void OnAppearing()
					{
						TermStart.Text=$"Term Start: {_currentTerm.StartDate.ToString("MM/dd/yy")}";
						TermEnd.Text = $"Term End: {_currentTerm.EndDate.ToString("MM/dd/yy")}";

						await _connection.CreateTableAsync<Course>();
						var myCourseList  = await _connection.QueryAsync<Course>($"SELECT * FROM Courses WHERE Term = '{_currentTerm.ID}'");
						_courseList = new ObservableCollection<Course>(myCourseList);
						CourseLV.ItemsSource = _courseList;
						base.OnAppearing();
					}

				private async void Course_Tapped(object sender, ItemTappedEventArgs e)
					{
						Course myCourse = (Course)e.Item;
						await Navigation.PushAsync(new CoursePage(myCourse));
					}

				private async void AddCourseBtn(object sender, EventArgs e)
					{
						await Navigation.PushModalAsync(new AddCourse(_currentTerm));
					}
		
				async void EditTermBtn(object sender, EventArgs e)
					{
						await Navigation.PushModalAsync(new EditTerm(_currentTerm));
					}

				private async void DeleteTermBtn(object sender, EventArgs e)
					{
						var answer = await DisplayAlert("Caution", "Do you want to delete this term?", "Yes", "No");

						if (answer)
							{
								await _connection.DeleteAsync(_currentTerm);
								await Navigation.PopToRootAsync();
							}
					}
			}
	}