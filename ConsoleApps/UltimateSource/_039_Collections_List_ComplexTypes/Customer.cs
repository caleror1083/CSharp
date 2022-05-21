using System;

namespace _039_Collections_List_ComplexTypes
	{
		internal class Customer : IComparable<Customer>
			{
				// Properties
				public int ID { get; set; }
				public string Name { get; set; }
				public int Salary { get; set; }
				public string Type { get; set; }
				public int Experience { get; set; }

				// compares the current instance with another object of the same type and returns an integer
				public int CompareTo(Customer other)
					{
						return Salary.CompareTo(other.Salary);    // sort based on Property name
					}
			}
	}