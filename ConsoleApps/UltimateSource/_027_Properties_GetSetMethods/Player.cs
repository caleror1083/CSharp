using System;
		class Player
			{
				private int maxHealth = 100;
				private int _health = 100;
				
				public int health
					{
						get
							{
								return _health;
							}
						set
							{
								if(value <= 0)
									{
										_health = 0;
									}
								else if(value >= maxHealth)
									{
										_health = maxHealth;
									}
								else
									{
										_health = value;
									}
							}
					}

				     public void Message()
        {
            Console.WriteLine(health);
            health -= 200;

            Console.WriteLine(health);
            health += 400;

            Console.WriteLine(health);
        }

				/*
					public void Damage(int _amount)
						{
							_health -= _amount;
						}
				*/
			}