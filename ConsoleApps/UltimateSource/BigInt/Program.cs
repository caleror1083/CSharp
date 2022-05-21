using System;
using System.Numerics;

namespace BigInt
{
	class Program
	{
		static void Main(string [] args)
		{
		           // ---------- BIGINTEGER ----------
            // Used to store very large numbers
            // Select Project -> Add Reference
            // Select Assemblies -> System.Numerics.dll click Ok
            // Add this line using System.Numerics; at the top

            // Define the value using a text literal
            BigInteger bigNum = BigInteger.Parse("12345123451234512345");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);
            Console.WriteLine("");
		}
	}
}