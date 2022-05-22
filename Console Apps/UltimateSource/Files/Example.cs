// Robert Calero - App displaying arrays
using System;
using System.IO;

class Example
	{
		public void Results()
			{
				Console.WriteLine("Example 1: ");
				string[] custs = new string[] { "Rob", "Paul", "Greg" };

				using (StreamWriter sw = new StreamWriter(@"F:\CPU Programming\C Sharp\NET Framework\Console Applications\UltimateSource\Files\bin\Debug\customers.txt"))
					{
						foreach (string cust in custs)
							{
								sw.WriteLine(cust);
							}
					}

				string custName = "";
				using (StreamReader sr = new StreamReader(@"F:\CPU Programming\C Sharp\NET Framework\Console Applications\UltimateSource\Files\bin\Debug\customers.txt"))
					{
						while ((custName = sr.ReadLine()) != null)
							{
								Console.WriteLine(custName);
							}
					}
			}
	}