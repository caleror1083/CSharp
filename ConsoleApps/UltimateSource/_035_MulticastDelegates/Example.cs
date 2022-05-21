// Robert Calero - App displaying delegates
using System;

namespace _035_MulticastDelegates
	{
		class Example
			{
				public static void Method1()    // This method prints a message to the console
					{
						Console.WriteLine("Method1 called");
					}

				public static void Method2()
					{
						Console.WriteLine("Method2 called");
					}

				public static void Method3()
					{
						Console.WriteLine("Method3 called");
					}

				public static int SampleMethodFour()
					{
						return 1;
					}
			}
	}