// Robert Calero - App demonstrating abstract classes
class Rectangle : Shape
    {
        private readonly double _Length;
        private readonly double _Width;

        public Rectangle(double lengthParam, double widthParam)
            {
                _Length = lengthParam;
                _Width = widthParam;
            }

        public override double Area()    // derived class must provide implementation for all abtract members.
            {
                return _Length * _Width; 
            }

        public static Rectangle operator+(Rectangle rect1, Rectangle rect2)
            {
                double rectLength = rect1._Length + rect2._Length;
                double rectWidth = rect1._Width + rect2._Width;

                return new Rectangle(rectLength, rectWidth);
            }
    }