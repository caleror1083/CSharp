using System;
using System.Linq;

namespace LINQ_To_SQL
    {
        class Example
            {
                public void Result()
					{
						int UserNumber;
						// Accepting value from user
						Console.WriteLine("Welcome to my company database, what would you like to do?\nPressing 1 will show current data\nPressing 2 will insert a new row to the table\nPressing 3 will update a row in the table\nPressing 4 will delete a row from the table");
						UserNumber = int.Parse(Console.ReadLine());

						if (UserNumber == 1)
							{
								Console.WriteLine("");
								SelectAllData();
							}
						else if (UserNumber == 2)
							{
								Console.WriteLine("");
								InsertRowData();
							}
						else if (UserNumber == 3)
							{
								Console.WriteLine("");
								UpdateRowData();
							}
						else if (UserNumber == 4)
							{
								Console.WriteLine("");
								DeleteRowData();
							}
						else
							{
								Console.WriteLine("Incorrect option exiting application");
							}
					}

				private static void SelectAllData()
					{
						// Declare an object of the DataContext
						IndexCompanyDataContext dbContext = new IndexCompanyDataContext();

						// LINQ query to retrieve data from Employees table
						var employeesInfo = dbContext.Employees;

						Console.WriteLine($"ID\t FirstName\t LastName\t Gender\t Salary\t DepartmentID\n");

						// Iterate through Employees table displaying the data
						foreach (var record in employeesInfo)
							{
								Console.WriteLine($"{record.ID}\t {record.FirstName}\t\t {record.LastName}\t {record.Gender}\t {record.Salary}\t {record.DepartmentsID}");
							}
						Console.WriteLine();
					}

				private static void InsertRowData()
					{
						using (IndexCompanyDataContext dbContext = new IndexCompanyDataContext())
							{
								Employees newEmployee = new Employees
									{
										FirstName = "Tim",
										LastName = "T",
										Gender = "Male",
										DepartmentsID = 1,
										Salary = 55000
									};

								dbContext.Employees.InsertOnSubmit(newEmployee);
								dbContext.SubmitChanges();
							}
						SelectAllData();
					}

				private static void UpdateRowData()
					{
						using (IndexCompanyDataContext dbContext = new IndexCompanyDataContext())
							{
								Employees employee = dbContext.Employees.SingleOrDefault(x => x.ID == 8);
								employee.Salary = 65000;
								dbContext.SubmitChanges();
							}
						SelectAllData();
					}
				
				private static void DeleteRowData()
					{
						using (IndexCompanyDataContext dbContext = new IndexCompanyDataContext())
							{
								Employees employee = dbContext.Employees.SingleOrDefault(x => x.ID == 8);
								dbContext.Employees.DeleteOnSubmit(employee);
								dbContext.SubmitChanges();
							}
						SelectAllData();
					}
			}
    }