// Robert Calero - App displaying instance methods
using System;

class Example
	{
		public int Age = 0; // field declaration

		public void Results()    // instance method
			{
				Console.WriteLine("Example 1:");
				Example method1 = new Example();    // invoking instance method EvenNumbers
				method1.EvenNumbers();
				Console.WriteLine();

				Console.WriteLine("Example 2:");    // passing parameters by value
				Example method2 = new Example();    // invoking instance method Add with parameters

				int no1, no2, sum;

				Console.Write("Please enter 1st number: ");
				no1 = int.Parse(Console.ReadLine());

				Console.Write("Please enter 2nd number: ");
				no2 = int.Parse(Console.ReadLine());

				sum = method2.Add(no1, no2);

				Console.WriteLine($"Sum is {sum}");
				Console.WriteLine();

				Console.WriteLine("Example 3:");
				Example method3 = new Example { Age = 18 };    // invoking instance method EvenNumbers
				Console.WriteLine(method3.GetAge());
				Console.WriteLine();

				Console.WriteLine("Example 4:");
				Example method4 = new Example();    // invoking instance method EvenNumbers
				method4.SetAge(35);
				Console.Write(method4.GetAge());
				Console.ReadKey();
			}

		void EvenNumbers()    // instance method
			{
				int Start = 0;

				while (Start <= 20)
					{
						Console.WriteLine(Start);
						Start += 2;
					}
			}

		int Add(int num1, int num2)    // instance method with parameters
			{
				return num1 + num2;
			}

		int GetAge()    // instance method
			{	
				return Age;
			}

		void SetAge(int nAge)    // instance method with parameters
			{	
				Age = nAge;
			}
	}