using System;	// namespace declaration

// namespace
namespace _033_ExceptionHandling
	{
		// classes
		class UserLoggedInException : Exception
			{
				// constructors
				public UserLoggedInException(string message) : base(message) {}
			}
	}