using System;
using System.Linq.Expressions;
using System.Reflection;

public class Example
	{
		public void Result()
			{
				Student student = new Student();
				Console.WriteLine(getPropertyName(() => student.StudentID));
				Console.WriteLine(getPropertyName(() => student.Name));
				Console.WriteLine(getPropertyName(() => student.Age));
				Console.WriteLine(getPropertyName(() => student.Phone));
	}

		// This method is passing a lambda as a LINQ expression and extracting the property name
		static string getPropertyName<Type>(Expression<Func<Type>>lambdaExp)
			{
				MemberExpression myMemberExpression = lambdaExp.Body as MemberExpression;
				MemberInfo myMemberInfo = myMemberExpression.Member;
				return myMemberInfo.Name;
			}
	}