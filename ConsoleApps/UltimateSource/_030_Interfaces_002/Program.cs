// Robert Calero - App demonstrating interfaces
using System;

class Program
	{
		static void Main()    // Main method begins execution of C# app
				{
					Sword sword = new Sword("Excalibur");
					sword.Equip();
					sword.TakeDamage(20);
					sword.Sell();

					Console.WriteLine();

					Axe axe = new Axe("Golden Axe");
					axe.Equip();
					axe.TakeDamage(20);
					axe.Sell();

					Console.WriteLine();

					// create an inventory
					IItem[] inventory = new IItem[2];    // interface reference variable pointing to an interface
					inventory[0] = sword;
					inventory[1] = axe;

					// loop through and turn in all quest items
					for (int i = 0; i < inventory.Length; i++)
						{
							IPartOfQuest questItem = inventory[i] as IPartOfQuest;
							if(questItem != null)
								{
									questItem.TurnIn();
								}
						}
				}
	}