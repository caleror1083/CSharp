﻿// Robert Calero - App demonstrating how to protect class fields using get and set methods
using System;

public class Student
	{
		private int _ID;
		private string _Name;
		private readonly int _PassMark = 60;

		public void SetID(int paramID)
			{
				if (paramID <= 0)
					{
						throw new Exception("Student ID cannot be negative");
					}
				_ID = paramID;
			}

		public int GetID()
			{
				return _ID;
			}

		public void SetName(string paramName)
			{
				if (string.IsNullOrEmpty(paramName))
					{
						throw new Exception("Name cannot be null or empty");
					}
				_Name = paramName;
			}

		public string GetName()
			{
				return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
			}

		public int GetPassMark()
			{
				return _PassMark;
			}

		public void PrintID()
			{
				SetID(101);
				Console.WriteLine($"Student ID = {GetID()}");
			}

		public void PrintName()
			{
				SetName("Rob");
				Console.WriteLine($"Student Name = {GetName()}");
			}

		public void PrintPassMark()
			{
				Console.WriteLine($"PassMark = {GetPassMark()}");
			}
	}