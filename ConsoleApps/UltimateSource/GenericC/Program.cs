// Robert Calero - Generics

// Generics - Anything that is not specific to a particular data type

class Program
	{
		static void Main()
			{
				// Instantiate an object of class GenericList
				GenericList<string, int> meaning = new GenericList<string, int> ("Life", 42);
				meaning.PrintGeneric();    // Calls the PrintGeneric method from the GenericList class
			}
	}