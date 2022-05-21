// Robert Calero - App displaying namespaces
using System;
using PATA = _018_ProjectA.TeamA;    // namespace alias
using PATB = _018_ProjectA.TeamB;

namespace _018_Namespaces
	{
		class Example
			{
				public void Results()
					{
						Console.WriteLine("Example 1: Namespaces");
						PATA.ClassA.Print();
						Console.WriteLine();
						PATB.ClassA.Print();
					}
			}
	}