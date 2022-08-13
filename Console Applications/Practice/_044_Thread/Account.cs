using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _044_Thread
	{
		// Classes
		internal class Account
			{
				// Properties
				public int ID { get; }
				public double Balance { get; set; }

				// Constructors(Parameters)
				public Account(int id, double balance)
					{
						ID = id;
						Balance = balance;
					}

				// Methods(Parameters)
				public void Withdraw(double amount)
					{
						Balance -= amount;
					}

				public void Deposit(double amount)
					{
						Balance += amount;
					}
			}
	}