using System;

class GenericList<TKey, TValue>	// Generic class declaration with types
	{
		public TKey key;
		public TValue value;
		public GenericList (TKey _key, TValue _value)
			{
				key = _key;
				value = _value;
			}

		public void PrintGeneric()
			{
				Console.WriteLine("Key: " + key.ToString());
				Console.WriteLine("Value: " + value.ToString());
				Console.WriteLine();
			}
	}