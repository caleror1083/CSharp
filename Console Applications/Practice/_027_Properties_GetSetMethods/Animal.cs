using System;
using System.Linq;

// Namespaces
namespace _027_Properties_GetSetMethods
    {
        internal class Animal
            {
                // Fields
                private string _Name;
                private string _Sound;
                public const string SHELTER = "Derek's Home for Animals";  // You can define constants
                public readonly int idNum;  // You can define read-only fields that are set at runtime in constructors, but then can't be changed

                // Properties
                public string Sound  // The preferred way to define getters and setters is through properties
                    {
                        get { return _Sound; }
                        set
                            {
                                if (value.Length > 10)  // Value is assigned the value passed in
                                    {
                                        _Sound = "No Sound";
                                        Console.WriteLine("Sound is too long");
                                    }
                                else
                                    {
                                        _Sound = value;
                                    }
                            }
                    }

                // Constructors(Parameters)
                public Animal() : this("No Name", "No Sound") { }

                public Animal(string name) : this(name, "No Sound") { }  // Constructor called if only name is passed this passes the parameters to the next constructor
                
                public Animal(string name, string sound)  // Constructor that receives parameters
                    {
                        SetName(name);
                        Sound = sound;
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
                        Console.WriteLine($"{_Name} says {_Sound}");
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