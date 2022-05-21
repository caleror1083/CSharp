﻿// Robert Calero - App displaying arrays

// Namespace
namespace _010_Arrays
	{
		// Classes
		class Program    // Class declaration - a class defines the variables and methods used by objects
			{
				/* The main function is where execution begins.
				   static methods belong to the class and can be executed without needing to create an object.
				   void means that this method doesn't return a value after it executes, but it is common to use int instead
				   if int is utilized it will return an integer value 0 when successfully executed or -1 when an error occurred.
				   this function can receive multiple string values that are saved into an array */
				// Methods(Parameters)
				static void Main()
					{
						// Object creation and instances
						Examples myExamples = new Examples();

						// Statements
						myExamples.ProcessExamples();

					}    // end main
			}    // end class Program
	}