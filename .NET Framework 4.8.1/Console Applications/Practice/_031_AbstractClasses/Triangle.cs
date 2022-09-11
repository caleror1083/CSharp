// Namespaces
namespace _031_AbstractClasses
    {
        class Triangle : Shape
            {
                // Properties
                public double Base { get; set; }
                public double Height { get; set; }

                // Constructors
                public Triangle(double basex, double height)
                    {
                        Base = basex;
                        Height = height;
                    }

                // Overriden methods
                public override double Area()    // derived class must provide implementation for all abtract members.
                    {
                        return .5 * (Base * Height);
                    }
            }
    }