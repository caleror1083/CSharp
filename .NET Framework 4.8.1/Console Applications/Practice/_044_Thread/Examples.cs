using System;
using System.Diagnostics;
using System.Threading;

namespace _044_Thread
	{
		internal class Examples
			{
				public void ProcessExamples()
					{
						bool check;
						string decision;

						Start:
							Console.Write("Please select an example from 1-10: ");
							check = int.TryParse(Console.ReadLine(), out int choice);

							if (check)
								{
									switch (choice)
										{
											case 1:
												Example1();
												break;
											case 2:
												Example2();
												break;
											case 3:
												Example3();
												break;
											case 4:
												Example4();
												break;
											case 5:
												Example5();
												break;
											case 6:
												Example6();
												break;
											case 7:
												Example7();
												break;
											case 8:
												Example8();
												break;
											case 9:
												Example9();
												break;
											case 10:
												Example10();
												break;
											default:
												Console.WriteLine("Your choice is invalid");
												goto Start;
										}
								}
							else
								{
									Console.WriteLine($"Selection chosen is incorrect");
									goto Start;
								}

						Decide:
							Console.Write("Do you want to do another example? - Yes or No: ");
							decision = Console.ReadLine();
							Console.WriteLine();

							switch (decision.ToUpper())
								{
									case "YES":
										goto Start;
									case "NO":
										break;
									default:
										Console.WriteLine("Your decision is invalid. Try again");
										goto Decide;
								}
					}

				static void Example1()
					{
						Thread thread1 = new Thread(Number.PrintNumbers);  // Utilizing the ThreadStart delegate, passing the name of the PrintNumbers method that we want the thread to execute
						thread1.Start();  // When this line execute, the program will run PrintNumbers()
						thread1.Join();
					}

				static void Example2()
					{
						Console.Write($"Please enter the target number: ");
						object target = Console.ReadLine();

						Thread thread1 = new Thread(Number.PrintTargetNumbers); // Utilizing the ParameterizedThreadStart delegate
						thread1.Start(target);
						thread1.Join();
					}

				static void Example3()
					{
						Console.Write($"Please enter the target number: ");
						int chosenNumberTarget = int.Parse(Console.ReadLine());

						Number number = new Number(chosenNumberTarget);
						Thread thread1 = new Thread(number.PrintTargetNumbersSafe); // Utilizing the ThreadStart delegate in a type safe manner
						thread1.Start();
						thread1.Join();
					}

				static void Example4()
					{
						Console.Write($"Please enter the target number: ");
						int chosenNumberTarget = int.Parse(Console.ReadLine());

						SumofNumbers cbDel = new SumofNumbers(PrintSum); // Callback delegate that points to the method
						Number number = new Number(chosenNumberTarget, cbDel);
						Thread thread1 = new Thread(number.PrintComputeTargetNumber); // Utilizing the ThreadStart delegate in a type safe manner
						thread1.Start();
						thread1.Join();
					}

					static void PrintSum(int sumOfNumbers) // Callback method
					{
						Console.WriteLine($"The sum of the target number entered is {sumOfNumbers}");
					}

				static void Example5()
					{
						// Joining threads
						Console.WriteLine("Main started");      // Main method is always 1st thread
						Thread thread1 = new Thread(Thread1);    // Worker thread
						thread1.Start();
						
						// time willing to wait until the thread completes execution
						if (thread1.Join(1000))    // forces Main thread to wait for other threads to complete
							{
								Console.WriteLine("Thread1 has completed");
							}
						else
							{
								Console.WriteLine("Thread1 has not completed");
							}

						Thread thread2 = new Thread(Thread2);
						thread2.Start();
						thread2.Join();
						Console.WriteLine("Thread2 completed");

						for (int i = 1; i <= 10; i++) // repeatedly check if Thread1 is still alive
							{
								if (thread1.IsAlive)  // Thread1 still working
									{
										Console.WriteLine("Thread1 still processing");
										Thread.Sleep(500);
									}
								else
									{
										Console.WriteLine("Thread1 completed");
										break;
									}
							}
						Console.WriteLine("Main completed");
					}

					static void Thread1()
					{
						Console.WriteLine("Thread1 started");
						Console.WriteLine("Thread1 almost complete");
						Thread.Sleep(5000);    // sleep for 5 seconds
					}

					static void Thread2()
					{
						Console.WriteLine("Thread2 started");
					}

				static void Example6() // single threaded application
					{
						Number add = new Number();
						add.AddOneMillionSingle();
						add.AddOneMillionSingle();
						add.AddOneMillionSingle();

						Console.WriteLine($"Total = {add._Total}");
					}

				static void Example7() // multi threaded application
					{
						Number add = new Number();
						Thread thread1 = new Thread(add.AddOneMillionMulti);
						Thread thread2 = new Thread(add.AddOneMillionMulti);
						Thread thread3 = new Thread(add.AddOneMillionMulti);

						thread1.Start();
						thread2.Start();
						thread3.Start();

						thread1.Join();
						thread2.Join();
						thread3.Join();

						Console.WriteLine($"Total = {add._Total}");
					}

				static void Example8() // multi threaded application
					{
						Number add = new Number();
						Thread thread1 = new Thread(add.AddOneMillionLock);
						Thread thread2 = new Thread(add.AddOneMillionLock);
						Thread thread3 = new Thread(add.AddOneMillionLock);

						thread1.Start();
						thread2.Start();
						thread3.Start();

						thread1.Join();
						thread2.Join();
						thread3.Join();

						Console.WriteLine($"Total = {add._Total}");
					}

				static void Example9()    // multi threaded application
					{
						// Provides a set of methods and properties that you can use to accurately measure elapsed time
						// Sets the elapsed time property to zero and starts measuring elapsed time
						Stopwatch myStopwatch = Stopwatch.StartNew();

						Number add = new Number();
						Thread thread1 = new Thread(add.AddOneMillionMonitor);
						Thread thread2 = new Thread(add.AddOneMillionMonitor);
						Thread thread3 = new Thread(add.AddOneMillionMonitor);

						thread1.Start();
						thread2.Start();
						thread3.Start();

						thread1.Join();
						thread2.Join();
						thread3.Join();

						Console.WriteLine($"Total = {add._Total}");
						
						myStopwatch.Stop();  // Stops measuring elapsed time for an interval
						Console.WriteLine($"Time taken in ticks: {myStopwatch.ElapsedTicks}");  // Gets the total elapsed time measured by the current instance im timer ticks
					}

				static void Example10()  // Deadlock
					{
						Console.WriteLine("Main started");
						Account a = new Account(101, 5000);
						Account b = new Account(102, 3000);

						AccountManager managerA = new AccountManager(a, b, 1000);
						Thread t1 = new Thread(managerA.Transfer);
						t1.Name = "Thread 1";

						AccountManager managerB = new AccountManager(b, a, 2000);
						Thread t2 = new Thread(managerB.Transfer);
						t2.Name = "Thread 2";

						t1.Start();
						t2.Start();

						t1.Join();
						t2.Join();
						Console.WriteLine("Main completed");
					}
			}
	}