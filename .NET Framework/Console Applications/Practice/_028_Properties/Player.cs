using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Player
			{
				// Fields
				private int _MaxHealth = 100;
				private int _Health = 100;
				
				// Properties
				public int Health
					{
						get
							{
								return _Health;
							}
						set
							{
								if (value <= 0)
									{
										_Health = 0;
									}
								else if (value >= _MaxHealth)
									{
										_Health = _MaxHealth;
									}
								else
									{
										_Health = value;
									}
							}
					}

				// Methods(Parameters)
				public void Message()
					{
						Console.WriteLine(Health);
						Health -= 200;

						Console.WriteLine(Health);
						Health += 400;

						Console.WriteLine(Health);
					}
			}
	}