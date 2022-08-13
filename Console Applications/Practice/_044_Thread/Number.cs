using System;
using System.Threading;

namespace _044_Thread
	{
		internal class Number
			{
				// Fields
				private readonly int _Target; // Data that the thread method requires
				private readonly SumofNumbers _CallbackMethod;
				public int _Total = 0;
				private readonly object _Lock = new object();

				// Constructors
				public Number() {}

				public Number(int target)
					{
						_Target = target;
					}

				public Number(int target, SumofNumbers callbackMethod)
					{
						_Target = target;
						_CallbackMethod = callbackMethod;
					}

				// Methods(Parameters)
				public static void PrintNumbers()
					{
						for (int i = 1; i <= 10; i++)  // Print numbers from 1-10
							{
								Console.WriteLine(i);
							}
					}

				public static void PrintTargetNumbers(object target)  // Non Type Safe manner using ParameterizedThreadStart
					{
						if (int.TryParse(target.ToString(), out int number))
							{
								for (int i = 1; i <= number; i++)
									{
										Console.WriteLine(i);  // Prints the target number entered by the user via for loop
									}
							}
					}

				public void PrintTargetNumbersSafe()  // Using Type Safe manner - Thread method
					{
						for (int i = 1; i <= _Target; i++)
							{
								Console.WriteLine(i);
							}
					}

				public void PrintComputeTargetNumber()  // Method will print and compute sum of numbers entered by the user
					{
						int sumNumbers = 0;

						for (int i = 1; i <= _Target; i++)
							{
								sumNumbers += i;
							}
						_CallbackMethod?.Invoke(sumNumbers); // check if callback method is not null then call the delegate
					}

				public void AddOneMillionSingle()
					{
						for (int i = 1; i <= 1000000; i++)
							{
								_Total++;
							}
					}

				public void AddOneMillionMulti()
					{
						for (int i = 1; i <= 1000000; i++)
							{
								Interlocked.Increment(ref _Total);
							}
					}

				public void AddOneMillionLock()
					{
						for (int i = 1; i <= 1000000; i++)
							{
								lock (_Lock)
									{
										_Total++;
									}
							}
					}

				public void AddOneMillionMonitor()
					{
						for (int i = 1; i <= 1000000; i++)
							{
								// Provides a mechanism that synchronizes access to objects
								// Acquires an exclusive lock on the specified object
								// The object on which to acquire the monitor lock
								Monitor.Enter(_Lock);    // Acquires the exclusive lock

								try    // within try block we are trying to execute the increment
									{
										// if there is an exception create a catch block
										// if you don't want to handle the exception and want to allow it to be thrown omit catch block
										_Total++;  
									}
								finally
									{
										// Releases an exclusive lock on the specified object
										// The object on which to release the lock
										Monitor.Exit(_Lock);
									}
							}
					}
			}
	}