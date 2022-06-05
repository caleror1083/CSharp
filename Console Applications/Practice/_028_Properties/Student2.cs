using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespaces
namespace _028_Properties
	{
		// Classes
		internal class Student2
			{
				// Fields
				private int _Average; // instance field

				// Proeprties
				public string Name { get; set; }
				public int Average
                    {
                        get // returns the Student's average
                            {
                                return _Average;
                            }
                        set  // sets the Student's average
                            {
                                // validate that studentAverage is > 0 and <= 100; otherwise,
                                // keep instance variable average's current value  
                                if (value > 0)
                                    {
                                        if (value <= 100)
                                            {
                                                _Average = value; // assign to instance variable
                                            }
                                    }
                            }
                    }

                // returns the Student's letter grade, based on the average
                public string LetterGrade
                    {
                        get
                            {
                                string letterGrade = string.Empty; // string.Empty is ""

                                if (_Average >= 90)
                                    {
                                        letterGrade = "A";
                                    }
                                else if (_Average >= 80)
                                    {
                                        letterGrade = "B";
                                    }
                                else if (_Average >= 70)
                                    {
                                        letterGrade = "C";
                                    }
                                else if (_Average >= 60)
                                    {
                                        letterGrade = "D";
                                    }
                                else 
                                    {
                                        letterGrade = "F";
                                    }

                                return letterGrade;
                            }
                    }

				// Constructors(Parameters)
				 public Student2(string studentName, int studentAverage)
                    {
                        Name = studentName;
                        Average = studentAverage; // sets average instance variable
                    }
			}
	}