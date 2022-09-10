using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Properties
	{
		internal class Animal
		{
			// Fields
			private string _Sound;

			// Properties
			public string Sound  // The preferred way to define getters and setters is through properties
				{
					get { return _Sound;}
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

			public Animal(string sound) // Constructor that receives parameters
				{
					Sound = sound;
				}

			public void MakeSound()
				{
					Console.WriteLine($"{_Sound}");
				}
		}
	}