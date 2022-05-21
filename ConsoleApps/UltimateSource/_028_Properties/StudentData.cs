using System;

namespace _028_Properties
	{
		internal class StudentData
			{
				// Fields
				private int _ID;
				private string _Name;

				// Constructors

				// Properties
				public int ID    // ID read/write property
					{
						set
							{
								if (value <= 0)
									{
										throw new Exception("Student ID cannot be 0 or negative");
									}
								_ID = value;
							}
						get
							{
								return _ID;
							}
				
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

				public int PassMark { get; set; }    // auto implemented PassMark property
				public string City { get; set; }    // auto implemented City property
			}
	}