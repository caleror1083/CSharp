using System.Collections.Generic;

namespace _039_Collections_List_ComplexTypes
{
	internal class SortByName : IComparer<Customer>
			{
				public int Compare(Customer customer1, Customer customer2)
					{
						return customer1.Name.CompareTo(customer2.Name);
					}
			}
	}