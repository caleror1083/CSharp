// Robert Calero - App demonstrating static class memberss
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
				float Area1;
				float Area2;

				Circle myCircle = new Circle(5);
				Area1 = myCircle.CalculateArea();

				Console.WriteLine("Area = {0}", Area1);

				Circle myCircle2 = new Circle(6);
				Area2 = myCircle2.CalculateArea();

				Console.WriteLine("Area = {0}", Area2);
			}
	}