// Robert Calero - App demonstrating structures
using System;

public struct Customer
	{
		private int _ID;
		private string _Name;

		public Customer(int paramID, string paramName)
			{
				_ID = paramID;
				_Name = paramName;
			}

		public int ID    // ID read/write property
			{
				set
					{
						if (value <= 0)
							{
								throw new Exception("Customer ID cannot be negative");
							}
						_ID = value;
					}
				get { return _ID; }
			}

		public string Name    // Name read/write property
			{
				set
					{
						if (string.IsNullOrEmpty(value))
							{
								throw new Exception("Name cannot be null or empty");
							}
						_Name = value;
					}
				get
					{
						return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
					}
			}

		public void PrintID()
			{
				Console.WriteLine($"Customer ID = {ID}");
			}

		public void PrintName()
			{
				Console.WriteLine($"Customer Name = {Name}");
			}
	}