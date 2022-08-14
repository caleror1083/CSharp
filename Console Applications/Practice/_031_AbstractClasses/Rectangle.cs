// Namespaces
namespace _031_AbstractClasses
    {
        class Rectangle : Shape
            {
                // Properties
                public double Length { get; set; }
                public double Width { get; set; }

                // Constructors
                public Rectangle(double length, double width)
                    {
                        Length = length;
                        Width = width;
                    }

                // Overriden methods
                public override double Area()    // derived class must provide implementation for all abtract members.
                    {
                        return Length * Width; 
                    }

                // Operators
                public static Rectangle operator+(Rectangle rectangle1, Rectangle rectangle2)
                    {
                        double lengthRectangle = rectangle1.Length + rectangle2.Length;
                        double widthRectangle = rectangle1.Width + rectangle2.Width;

                        return new Rectangle(lengthRectangle, widthRectangle);
                    }
            }
    }