using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Account2  // Account class with a balance and a deposit method
			{
				// Fields
				private decimal _Balance;  // instance field
				
				// Properties
				public string Name { get; set; }  // auto-implemented property
				public decimal Balance  // Balance property with validation
					{
						get { return _Balance; }
						private set // Can be used only within the class
							{
								if (value > 0.0M)  // Validate that the balance is greater than 0.0, if not balance keeps value
									{
										_Balance = value;
									}
							}
					}

				// Constructors(Parameters)
				public Account2(string accountName, decimal initialBalance)  // Account constructor that receives two parameters
					{
						Name = accountName;
						Balance = initialBalance;  // Balance field set accessor validates
					}

				// Methods(Parameters)
				public void Deposit(decimal depositAmount)  // Method that deposits only a valis amount to the balance
					{
						if (depositAmount > 0.0m)  // If the depositAmount is valis
							{
								Balance += depositAmount;  // Add it to the balance
							}
					}
			}
	}