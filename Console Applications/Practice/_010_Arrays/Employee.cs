using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Arrays
	{
		internal class Employee
			{
				// Properties
				public int ID { get; set; }

				// Constructors
				public Employee(int id)
					{
						ID = id;
					}

				public override string ToString()
					{
						return Convert.ToString(ID);
					}
			}
	}