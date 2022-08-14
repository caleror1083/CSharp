using System;

namespace _045_Collections_Objects_ArrayList
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
