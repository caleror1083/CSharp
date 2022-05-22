// Robert Calero - App displaying arrays
using System;
using System.IO;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1: ");
				string[] custs = new string[] { "Rob", "Paul", "Greg" };

				using (StreamWriter sw = new StreamWriter(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\customers.txt"))
					{
						foreach (string cust in custs)
							{
								sw.WriteLine(cust);
							}
					}

				string custName = "";
				using (StreamReader sr = new StreamReader(@"C:\Users\Rob C\source\repos\CSharp\Console Applications\Practice\Files\bin\Debug\customers.txt"))
					{
						while ((custName = sr.ReadLine()) != null)
							{
								Console.WriteLine(custName);
							}
					}
			}
	}