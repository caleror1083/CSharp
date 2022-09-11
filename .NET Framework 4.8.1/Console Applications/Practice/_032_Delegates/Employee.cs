// Robert Calero - App displaying delegates
using System;
using System.Collections.Generic;

namespace _032_Delegates
	{
		class Employee
			{				
				public int ID { get; set; }    // auto implemented ID property
				public string Name { get; set; }    // auto implemented Name property
				public int Salary { get; set; }    // auto implemented Salary property
				public int Experience { get; set; }    // auto implemented Experience property
				
				public void EmployeeInformation()
					{
						List<Employee> EmpList = new List<Employee>
							{
								new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 },
								new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 },
								new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 },
								new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 }
							};
						PromoteEmployees(EmpList, Employee => Employee.Experience >= 5);    // Lambda expression
					}

				public static void PromoteEmployees(List<Employee> EmployeeList, IsPromotable IsEligible)    // This method takes in a list of employees and display the employees who are eligible for promotion
					{
						foreach (Employee EmployeeInfo in EmployeeList)    // Loop through each EmployeeInfo in our EmployeeList
							{
								if (IsEligible(EmployeeInfo))    // If the employees experience is more than 5 years then they are eligible for promotion so we will display their name
									{
										Console.WriteLine($"{EmployeeInfo.Name} promoted");
									}
							}
					}
			}
	}