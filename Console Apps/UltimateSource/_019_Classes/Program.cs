// Robert Calero - App demonstrating classes
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
			{
                Customer customer1 = new Customer();
                Console.Write($"Customer 1 - What is you first name? ");
                customer1.FirstName = Console.ReadLine();

                Console.Write($"Customer 1 - What is you last name? ");
                customer1.LastName = Console.ReadLine();
                customer1.PrintFullName();

                Console.WriteLine();

                Console.Write($"Customer 2 - What is you first name? ");
                string name1 = Console.ReadLine();

                Console.Write($"Customer 2 - What is you last name? ");
                string name2 = Console.ReadLine();

				Customer customer2 = new Customer(name1, name2);
				customer2.PrintFullName();

			           // ----- OBJECT ORIENTED PROGRAMMING -----
            // A class models real world objects by
            // defining their attributes (fields) and
            // capabilities (methods)
            // Then unlike with structs you can 
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values like
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };

            fox.MakeSound();

            // Call the static method
            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());
            Console.WriteLine();

            // You can also create static utility
            // classes Project -> Add Class
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));
            Console.WriteLine();
			}
	}