/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using Plugin.LocalNotifications;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace WGU_C971
	{
		[DesignTimeVisible(false)]

		[Table("Terms")]
		public class Term
			{
				[PrimaryKey, AutoIncrement, Column("_id")]
				public int ID
					{
						get;
						set;
					}
				public string Title
					{
						get;
						set;
					}
				public DateTime StartDate
					{
						get;
						set;
					}
				public DateTime EndDate
					{
						get;
						set;
					}
			}

		[Table("Courses")]
		public class Course
			{
				[PrimaryKey, AutoIncrement, Column("_id")]
				public int ID
					{
						get;
						set;
					}
				public int Term 
					{
						get;
						set;
					}
				public string CourseName
					{
						get;
						set;
					}
				public string CourseStatus
					{
						get;
						set;
					}
				public DateTime StartDate
					{
						get;
						set;
					}
				public DateTime EndDate
					{
						get;
						set;
					}
				public string InstructorName
					{
						get;
						set;
					}
				public string InstructorEmail
					{
						get;
						set;
					}
				public string InstructorPhone
					{
						get;
						set;
					}
				public string Notes
					{
						get;
						set;
					}
				public int Notifications
					{
						get;
						set;
					}
			}

		[Table("Assessments")]
		public class Assessment
			{
				[PrimaryKey, AutoIncrement, Column("_id")]
				public int ID
					{
						get;
						set;
					}
				public string AssessmentName 
					{
						get;
						set;
					}
				public DateTime StartDate
					{
						get;
						set;
					}
				public DateTime EndDate
					{
						get;
						set;
					}
				public string AssessmentType
					{
						get;
						set;
					}
				public int Course
					{
						get;
						set;
					}
				public int Notifications
					{
						get;
						set;
					}
			}

		public partial class MainPage : ContentPage
			{
				private SQLiteAsyncConnection _connection;
				public ObservableCollection<Term> _termList;
				private bool _appearance = true;

				public MainPage()
					{
						InitializeComponent();
						_connection = DependencyService.Get<ISQLiteDB>().GetConnection();
						TermsLV.ItemTapped += new EventHandler<ItemTappedEventArgs>(Term_Clicked);
					}

				protected override async void OnAppearing()
					{
						await _connection.CreateTableAsync<Term>();
						await _connection.CreateTableAsync<Course>();
						await _connection.CreateTableAsync<Assessment>();
						var termList = await _connection.Table<Term>().ToListAsync();

					// Seed data if there are no terms
						if (!termList.Any())
							{
							// Seed data
								var newTerm = new Term();
								newTerm.Title = "Term 1";
								newTerm.StartDate = new DateTime(2020, 03, 01);
								newTerm.EndDate = new DateTime(2020, 08, 31);
								await _connection.InsertAsync(newTerm);
								termList.Add(newTerm);

								var newCourse = new Course();
								newCourse.CourseName = "Software I - C#";
								newCourse.StartDate = new DateTime(2020, 03, 01);
								newCourse.EndDate = new DateTime(2020, 03, 15);
								newCourse.CourseStatus = "Completed";
								newCourse.InstructorName = "Robert Calero";
								newCourse.InstructorPhone = "407-962-7014";
								newCourse.InstructorEmail = "rcalero@wgu.edu";
								newCourse.Notifications = 1;
								newCourse.Notes = "Some notes";
								newCourse.Term = newTerm.ID;
								await _connection.InsertAsync(newCourse);

								Assessment newObjectiveAssessment = new Assessment();
								newObjectiveAssessment.AssessmentName = "PFM1";
								newObjectiveAssessment.StartDate = new DateTime(2020, 03, 10);
								newObjectiveAssessment.EndDate = new DateTime(2020, 03, 13);
								newObjectiveAssessment.Course = newCourse.ID;
								newObjectiveAssessment.AssessmentType = "Objective";
								newObjectiveAssessment.Notifications = 1;
								await _connection.InsertAsync(newObjectiveAssessment);

								Assessment newPerformanceAssessment = new Assessment();
								newPerformanceAssessment.AssessmentName = "BFM1";
								newPerformanceAssessment.StartDate = new DateTime(2020, 03, 13);
								newPerformanceAssessment.EndDate = new DateTime(2020, 03, 15);
								newPerformanceAssessment.Course = newCourse.ID;
								newPerformanceAssessment.AssessmentType = "Performance";
								newPerformanceAssessment.Notifications = 1;
								await _connection.InsertAsync(newPerformanceAssessment);
							}
						var courseList = await _connection.Table<Course>().ToListAsync();
						var assessmentList = await _connection.Table<Assessment>().ToListAsync();

						// Sets notifications for course and assessment start/end times
						if (_appearance)
							{
								_appearance = false;
								int courseID = 0;

								foreach (Course myCourse in courseList)
									{
										courseID++;
										if (myCourse.Notifications == 1)
											{
												if (myCourse.StartDate == DateTime.Today)
													{
														CrossLocalNotifications.Current.Show("Course Starting Soon", $"{myCourse.CourseName} starts today!", courseID);
													}
												if (myCourse.EndDate == DateTime.Today)
													{
														CrossLocalNotifications.Current.Show("Course Ending Soon", $"{myCourse.CourseName} ends today!", courseID);
													}
											}
									}
								int assessmentID = courseID;

								foreach (Assessment myAssessment in assessmentList)
									{
										assessmentID++;
										if (myAssessment.Notifications == 1)
											{
												if (myAssessment.StartDate == DateTime.Today)
													{
														CrossLocalNotifications.Current.Show("Assessment Starting Soon", $"{myAssessment.AssessmentName} starts today!", assessmentID);
													}
												if (myAssessment.EndDate == DateTime.Today)
													{
														CrossLocalNotifications.Current.Show("Assessment Ending Soon", $"{myAssessment.AssessmentName} ends today!", assessmentID);
													}
											}
									}
							}
						_termList = new ObservableCollection<Term>(termList);
						TermsLV.ItemsSource = _termList;
						base.OnAppearing();
					}

				async private void Term_Clicked(object sender, ItemTappedEventArgs e)
					{
						Term myTerm = (Term)e.Item;
						await Navigation.PushAsync(new TermPage(myTerm));
					}

				private async void AddTermBtn_Clicked(object sender, EventArgs e)
					{
						await Navigation.PushModalAsync(new AddTerm(this));
					}
			}
	}