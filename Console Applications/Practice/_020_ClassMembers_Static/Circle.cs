// Robert Calero - App demonstrating static class members

class Circle
	{
		readonly static float _PI = 3.141F;    // static field
		readonly int _Radius;    // instance field

		public Circle(int Radius)    // constructor to initialize the class fields
			{
				_Radius = Radius;    // you can utilize this to refer to an object of the class
			}

		public float CalculateArea()
			{
				return _PI * _Radius * _Radius;
			}

		~Circle()    // Destructor used to cleanup and resources that the class was holding on to
			{
			}
	}