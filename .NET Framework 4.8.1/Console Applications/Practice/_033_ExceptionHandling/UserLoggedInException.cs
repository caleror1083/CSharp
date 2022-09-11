using System;

// Namespace
namespace _033_ExceptionHandling
	{
		// UserLoggedInException class inheriting from Exception class
		class UserLoggedInException : Exception
			{
				// Constructors
				public UserLoggedInException(string message) : base(message) {}
			}
	}