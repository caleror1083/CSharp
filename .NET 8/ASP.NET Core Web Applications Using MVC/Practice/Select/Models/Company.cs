namespace Select.Models;

public class Company
{
    public List<Employee>? EmployeeList { get; set; }
    
    public string this[int employeeID] // indexer
    {
        get
        {
            return EmployeeList.FirstOrDefault(employee => employee.EmployeeID == employeeID).Name;
        }
        set
        {
            EmployeeList.FirstOrDefault(employee => employee.EmployeeID == employeeID).Name = value;
        }
    }

    public string this[string gender] // overloading indexer
    {
        get
        {
            return EmployeeList.Count(employee => employee.Gender == gender).ToString();
        }
        set
        {
            foreach (Employee employee in EmployeeList)
            {
                if (employee.Gender == gender)
                {
                    employee.Gender = value;
                }
            }
        }
    }

    public Company()
    {
        EmployeeList =
        [
            new Employee() { EmployeeID = 1, Name = "Mike", Gender = "Male" },
            new Employee() { EmployeeID = 2, Name = "Pam", Gender = "Female" },
            new Employee() { EmployeeID = 3, Name = "John", Gender = "Male" },
            new Employee() { EmployeeID = 4, Name = "Maxine", Gender = "Female" },
            new Employee() { EmployeeID = 5, Name = "Emily", Gender = "Female" },
            new Employee() { EmployeeID = 6, Name = "Scott", Gender = "Male" },
            new Employee() { EmployeeID = 7, Name = "Todd", Gender = "Male" },
            new Employee() { EmployeeID = 8, Name = "Ben", Gender = "Male" },
        ];
    }
}