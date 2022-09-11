using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Namespaces
namespace _044_Thread
	{
		// Classes
		internal class AccountManager
			{
				// Properties
				public Account FromAccount { get; set; }
				public Account ToAccount { get; set; }
				public double AmountToTransfer { get; set; }

				// Constructors(Parameters)
				public AccountManager(Account fromAccount, Account toAccount, double amountToTranfer)
					{
						FromAccount = fromAccount;
						ToAccount = toAccount;
						AmountToTransfer = amountToTranfer;
					}

				public void Transfer()
					{
						// Variable declarations
						// This resolved deadlocks
						object lock1, lock2;

						if (FromAccount.ID < ToAccount.ID)
							{
								lock1 = FromAccount;
								lock2 = ToAccount;
							}
						else
							{
								lock1 = ToAccount;
								lock2 = FromAccount;
							}

						Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)lock1).ID}");
						lock (lock1)
							{
							    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)lock1).ID}");
								Console.WriteLine($"{Thread.CurrentThread.Name} suspended for 1 second");
								Thread.Sleep(1000);
								Console.WriteLine($"{Thread.CurrentThread.Name} back in action and trying to acquire lock on {((Account)lock2).ID}");
								lock (lock2)
									{
    									Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)lock2).ID}");
										FromAccount.Withdraw(AmountToTransfer);
										ToAccount.Deposit(AmountToTransfer);
										Console.WriteLine($"{Thread.CurrentThread.Name} transferred {AmountToTransfer} from {FromAccount.ID} to {ToAccount.ID}");
									}
							}
					}
			}
	}