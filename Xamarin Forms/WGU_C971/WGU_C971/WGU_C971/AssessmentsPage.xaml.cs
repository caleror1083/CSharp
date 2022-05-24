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
		public partial class AssessmentsPage : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				private ObservableCollection<Assessment> _assessmentList;
				private Course _currentCourse;
				

				public AssessmentsPage(Course myCourse)
					{
						InitializeComponent();
						Title = myCourse.CourseName;
						_currentCourse = myCourse;
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						AssessmentsLV.ItemTapped += new EventHandler<ItemTappedEventArgs>(Assessment_Tapped);
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Assessment>();
						var myAssessmentList  = await _connection.QueryAsync<Assessment>($"SELECT * FROM Assessments WHERE Course = '{_currentCourse.ID}'");
						_assessmentList = new ObservableCollection<Assessment>(myAssessmentList);
						AssessmentsLV.ItemsSource = _assessmentList;
						base.OnAppearing();
					}

				private async void Assessment_Tapped(object sender, ItemTappedEventArgs e)
					{
						Assessment myAssessment = (Assessment)e.Item;
						await Navigation.PushAsync(new AssessmentPage(myAssessment));
					}

				private async void AddAssessmentBtn(object sender, EventArgs e)
					{
						int assessmentCount = 0;
						bool assessmentCheck = true;
						
						foreach (Assessment myAssessment in _assessmentList)
							{
								if (myAssessment.AssessmentType == "Objective" || myAssessment.AssessmentType == "Performance")
									{
										assessmentCount++;
									}
							}
						if (assessmentCount == 2)
							{
								await DisplayAlert("Alert", "You already have the max amount of assessments", "Ok");
								assessmentCheck = false;
							}
						if (assessmentCheck)
							{
								await Navigation.PushModalAsync(new AddAssessment(_currentCourse));
							}
					}
			}
	}