// Robert Calero - App demonstrating interfaces
using System;

class Axe : IItem, IDamageable, IPartOfQuest
	{
		public string Name { get; set; }    // auto implemented Name property
		public int GoldValue { get; set; }    // auto implemented GoldValue property
		public int Durability { get; set; }    // auto implemented Durability property

		public Axe(string _name)
			{
				Name = _name;
				GoldValue = 500;
				Durability = 300;
			}

		public void Equip()
			{
				Console.WriteLine(Name + " equipped");
			}

		public void TakeDamage(int _dmg)
			{
				Durability -= _dmg;
				Console.WriteLine(Name + " damaged by " + _dmg + ". It now has a durability of " + Durability);
			}

		public void Sell()
			{
				Console.WriteLine(Name + " sold for " + GoldValue);
			}

		public void TurnIn()
			{
				Console.WriteLine(Name + " turned in");
			}
	}