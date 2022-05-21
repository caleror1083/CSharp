using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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