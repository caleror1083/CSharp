// Robert Calero - App demonstrating abstract classes
class Triangle : Shape
    {
        private readonly double _Base;
        private readonly double _Height;

        public Triangle(double num1, double num2)
            {
                _Base = num1;
                _Height = num2;
            }

        public override double Area()    // derived class must provide implementation for all abtract members.
            {
                return .5 * (_Base * _Height);
            }
    }