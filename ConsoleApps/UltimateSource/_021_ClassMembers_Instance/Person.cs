// Robert Calero - App demonstrating instance class members

class Person
	{
		readonly string _FirstName;    // instance field declaration
		readonly string _LastName;

		public Person(string paramFirstName, string paramLastName)    // constructor to initialize the class fields
			{
				_FirstName = paramFirstName;
				_LastName = paramLastName;
			}

		public string GetFullName()
			{
				return $"The fullname of the person is {_FirstName} {_LastName}";
			}

		~Person()    // Destructor used to cleanup and resources that the class was holding on to
			{
			}
	}