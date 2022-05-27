using System;
using System.Linq;

// We cover public, private, protected, constants,
// read-only fields, constructors, setters, getters, 
// properties and more on static

class Animal2
    {
        // Define fields that are protected with private
        // Private fields can only be accessed by
        // methods in the class and they are not 
        // accessible by subclasses
        // protected fields can only be accessed by
        // methods in the class and by subclasses
        private string name2;
        private string sound2;

        // You can define constants
        public const string SHELTER = "Derek's Home for Animals";

        // You can define read-only fields that are set
        // at runtime in constructors, but then can't
        // be changed
        public readonly int idNum;

        // Method (Capabilities)
        public void MakeSound2()
        {
            Console.WriteLine("{0} says {1}", name2, sound2);
        }

        // Default constructor
        public Animal2() : this("No Name", "No Sound") { }

        // Constructor called if only name is passed
        // this passes the parameters to the next
        // constructor
        public Animal2(string name2) : this(name2, "No Sound") { }

        // Constructor that receives parameters
        public Animal2(string name2, string sound2)
        {
            SetName(name2);
            Sound = sound2;

            // Increment the number of animals
            // property
            NumOfAnimals2 = 1;

            // Define the read-only value which is
            // the same for all Animals
            Random rnd = new Random();
            idNum = rnd.Next(1, 2147483640);
        }

        // Setters (Mutators) protect the fields 
        // from receiving bad data
        public void SetName(string name2)
        {
            // Any checks if any character in the string 
            // is a number and if so returns true
            // Since we won't allow numbers we will 
            // protect our data
            if (!name2.Any(char.IsDigit))
            {
                this.name2 = name2;
            }
            else
            {
                // We have this duplicated code because 
                // everything isn't a property
                this.name2 = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        // Getters (Accessors) can provide output
        // aside from the value stored
        public string GetName()
        {
            return name2;
        }

        // The preferred way to define getters and
        // setters is through properties
        public string Sound
        {
            get { return sound2; }
            set
            {
                // value is assigned the value passed in
                if (value.Length > 10)
                {
                    sound2 = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound2 = value;
                }
            }
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