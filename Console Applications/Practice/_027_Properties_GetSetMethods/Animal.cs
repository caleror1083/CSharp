using System;
using System.Linq;

// Namespaces
namespace _027_Properties_GetSetMethods
    {
        internal class Animal
            {
                // Fields
                private string _Name;
                public const string SHELTER = "Derek's Home for Animals";  // You can define constants
                public readonly int idNum;  // You can define read-only fields that are set at runtime in constructors, but then can't be changed

                // Constructors(Parameters)                
                public Animal(string name)  // Constructor that receives parameters
                    {
                        SetName(name);
                        NumOfAnimals2 = 1;  // Increment the number of animals property

                        Random rnd = new Random();// Define the read-only value which is the same for all Animals
                        idNum = rnd.Next(1, 2147483640);
                    }

                // Method(Parameters)
                public string GetName()  // Getters (Accessors) can provide output aside from the value stored
                    {
                        return _Name;
                    }

                public void SetName(string name)  // Setters (Mutators) protect the fields from receiving bad data
                    {
                        if (!name.Any(char.IsDigit))  // Any checks if any character in the string is a number and if so returns true. Since we won't allow numbers we will protect our data
                            {
                                _Name = name;
                            }
                        else
                            {
                                _Name = "No Name";  // We have this duplicated code because everything isn't a property
                                Console.WriteLine("Name can't contain numbers");
                            }
                    }

                public void MakeSound2()
                    {
                        Console.WriteLine($"{_Name}");
                    }

                // You can have the getters and setters
                // generated for you like this and also
                // set the default value
                public string Owner { get; set; } = "No Owner";

                // You can also define static properties
                public static int numOfAnimals2 = 0;

                public static int NumOfAnimals2
                {
                    get { return numOfAnimals2; }
                    set { numOfAnimals2 += value; }
                }
            }
    }