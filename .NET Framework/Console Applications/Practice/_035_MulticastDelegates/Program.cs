// Robert Calero - App displaying delegates
namespace _035_MulticastDelegates
	{
		class Program
			{
				static void Main()
					{
						// To have the delegate point to the method, create an instance of the delegate and to the constructor of the delegate pass in the name of the method
						Delegate Del = new Delegate(Example.Method1);

						// Delegate reference variable initializations
						Del += Example.Method2;
						Del += Example.Method3;

						// Statements
						Del();    // To call the multicast delegate
					}
			}
	}